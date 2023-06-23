using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;

using pc_service_calc.Events;
using pc_service_calc.NewObjectForms;
using pc_service_calc.Logics;

namespace pc_service_calc
{
    public partial class Form1 : Form
    {
        public delegate void CreateNew(GenericNewHelper helper);
        public CreateNew myDelegate;
        private BindingList<Zamowienie> addresses;
        int changeCurrentAddressInfoButton_state = 0;
        public Form1()
        {
            InitializeComponent();
            myDelegate = new CreateNew(createNewItem);
            addresses = new BindingList<Zamowienie>();
            ZamowListBox.DataSource = addresses;
            saveFileDialog1.Filter = "Save|*.dap";
            openFileDialog1.Filter = "Load|*.dap";
            changeCurrentAddressInfoButton_state = 0;
        }
        public Form1(string fileName)
        {
            InitializeComponent();
            myDelegate = new CreateNew(createNewItem);
            addresses = new BindingList<Zamowienie>();
            ZamowListBox.DataSource = addresses;
            saveFileDialog1.Filter = "Save|*.dap";
            openFileDialog1.Filter = "Load|*.dap";

            if (!string.IsNullOrWhiteSpace(fileName) && File.Exists(fileName))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                openFileDialog1.FileName = fileName;
                if (openFileDialog1.FileName != "")
                {
                    using (FileStream fs = (FileStream)openFileDialog1.OpenFile())
                    {
                        BindingList<Zamowienie> newAddresses = (BindingList<Zamowienie>)formatter.Deserialize(fs);
                        addresses = newAddresses;
                        ZamowListBox.DataSource = addresses;
                    }
                }
            }
            changeCurrentAddressInfoButton_state = 0;
        }
        private void addressListBox_SelectedIndexChanged(object sender, EventArgs e) // kod elementu "ListBox" odpowiadający za listę zamówień
        {
            UnclickAllButtons();
            Zamowienie WhatZamow = (Zamowienie)ZamowListBox.SelectedItem;
            currentZamowNameTextBox.Text = ""; // wyświetlanie pustego pola po uruchomieniu programu
            currentAddressDescriptionTextBox.Text = "";
            if (WhatZamow == null)
                return;

            personListBox.DataSource = WhatZamow.people;
            if (WhatZamow.people.Count > 0)  // jeśli ilość zamówień jest większa niż 0
            {
                personListBox.SetSelected(0, true); // wybierz element listy pod numerem"0"
                eventListBox.DataSource = WhatZamow.people[0].events;
            }
            else
            {
                eventListBox.DataSource = null; 
                eventListBox.Items.Clear(); // Wyczyść wyświetlaną listę
                currentPersonNameTextBox.Text = "";
                currentPersonDescriptionTextBox.Text = "";
            }
            currentZamowNameTextBox.Text = WhatZamow.name;  // wyświetl nazwę elementu listy z informacji o zamówieniu
            currentAddressDescriptionTextBox.Text = WhatZamow.description;

        }
        private void personListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnclickAllButtons();
            Person who = (Person)personListBox.SelectedItem;
            if (who == null)
            {
                currentPersonNameTextBox.Text = "";
                currentPersonDescriptionTextBox.Text = "";
                return;
            }

            who.generateWithdrawEvents(DateTime.Today);
            eventListBox.DataSource = who.events;
            currentPersonNameTextBox.Text = who.personName;
            currentPersonDescriptionTextBox.Text = who.description;
            Recount();
        }
        private void Recount()
        {
            Person who = (Person)personListBox.SelectedItem;
            currentPenaltyTextBox.Text = "";
            currentDebtTextBox.Text = "";
            if (who == null)
            {
                currentPersonNameTextBox.Text = "";
                currentPersonDescriptionTextBox.Text = "";
                todayDebtTextBox.Text = "";
                todayPenaltyTextBox.Text = "";
                return;
            }

            Report report = who.Simulate(DateTime.Now);
            todayDebtTextBox.Text = report.totalDepth.ToString();
            todayPenaltyTextBox.Text = report.totalPenalty.ToString();
        }
        private void newAddressButton_Click(object sender, EventArgs e) // kod przycisku, który tworzy nowy element listy
        {
            NewZamow test = new NewZamow(); 
            test.Owner = this;
            test.Show(); // wywołanie nowego okna w którym wpisuje się informacje o nowym zamówieniu
        }
        private void newPersonButton_Click(object sender, EventArgs e)
        {
            if (ZamowListBox.SelectedItem != null)
            {
                NewPerson test = new NewPerson(((Zamowienie)ZamowListBox.SelectedItem).name);
                test.Owner = this;
                test.Show();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Zapisać dane przed wyjściem?", "", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    if (!Save())
                        e.Cancel = true;
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }
        private void EventListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnclickAllButtons();
            SelectEvent();
        }
        private void SelectEvent()
        {
            groupBoxContract.Visible = false;
            groupBoxContract.Enabled = false;
            groupBoxLeave.Visible = false;
            groupBoxLeave.Enabled = false;
            groupBoxPayment.Visible = false;
            groupBoxPayment.Enabled = false;
            groupBoxCustomWriteOff.Visible = false;
            groupBoxCustomWriteOff.Enabled = false;
            currentEventDateTextBox.Text = "";
            lastTermEndDateTextBox.Text = "";

            if (ZamowListBox.SelectedItem == null || personListBox.SelectedItem == null || eventListBox.SelectedItem == null)
                return;

            Event curEvent = (Event)eventListBox.SelectedItem;
            currentEventDateTextBox.Text = curEvent.date.ToString().Substring(0, 11);
            switch (curEvent)
            {
                case PayEvent payEvent:
                    groupBoxPayment.Visible = true;
                    groupBoxPayment.Enabled = true;
                    numericUpDown1.Value = payEvent.moneyPaid;
                    break;
                case CustomWriteOff customWriteOff:
                    groupBoxCustomWriteOff.Visible = true;
                    groupBoxCustomWriteOff.Enabled = true;
                    numericUpDown6.Value = customWriteOff.moneyGot;
                    richTextBox3.Text = customWriteOff.commentary;
                    break;
                case ContractChangeEvent contractChangeEvent:
                    groupBoxContract.Visible = true;
                    groupBoxContract.Enabled = true;
                    Terms terms = contractChangeEvent.terms;
                    currentEventTermPaymentUpDown.Value = terms.payment;
                    currentEventTermPaymentDateUpDown.Value = terms.dayOfPayment.Day;
                    currentEventTermPenaltyUpDown.Value = (decimal)terms.penalty;
                    currentEventTermEndDateUpDown.Text = contractChangeEvent.endDate.ToString().Substring(0, 11);
                    break;
            }
            Person person = (Person)personListBox.SelectedItem;

            int pointer;
            for (pointer = person.events.Count - 1; ; pointer--)
            {
                if (person.events[pointer].GetType() == typeof(ContractChangeEvent))
                {
                    if (((ContractChangeEvent)person.events[pointer]).date <= DateTime.Now)
                        break;
                }
            }
            lastTermEndDateTextBox.Text = ((ContractChangeEvent)person.events[pointer]).endDate.ToString().Substring(0, 11);
        }
        private void deleteAddressButton_Click(object sender, EventArgs e) // kod przycisku usuwania elementu listy
        {
            if (ZamowListBox.SelectedItem == null) // jeśli lista jest pusta, przycisk nic nie robi
                return;
            DialogResult dialogResult = MessageBox.Show( 
                "Czy naprawdę chcesz usunąć zamówienie?" + ((Zamowienie)(ZamowListBox.SelectedItem)).ToString(),
                "Usunięcie zamówienia", 
                MessageBoxButtons.YesNo); // wywołanie okna dialogowego z pytaniem o potwierdzenie usunięcia elementu listy

            if (dialogResult != DialogResult.Yes) // jeśli wybrano odpowiedź pozytywną
                return;

            addresses.Remove((Zamowienie)ZamowListBox.SelectedItem);  // usuwanie aktualnie wybranego elementu
            ZamowListBox.SelectedItem = null;
            personListBox.DataSource = null;
            eventListBox.DataSource = null;
            Recount();
        }
        private void deletePersonButton_Click(object sender, EventArgs e)
        {
            if (personListBox.SelectedItem == null || ZamowListBox.SelectedItem == null)
                return;
            DialogResult dialogResult = MessageBox.Show(
                "Czy naprawdę chcesz usunąć klienta?" + ((Person)(personListBox.SelectedItem)).ToString(),
                "Usuwanie klienta",
                MessageBoxButtons.YesNo);

            if (dialogResult != DialogResult.Yes)
                return;

            ((Zamowienie)(ZamowListBox.SelectedItem)).people.Remove((Person)personListBox.SelectedItem);
            personListBox.SelectedItem = null;
            eventListBox.DataSource = null;
            Recount();
        }
        private void deleteEventButton_Click(object sender, EventArgs e)
        {
            if (personListBox.SelectedItem == null || ZamowListBox.SelectedItem == null || eventListBox.SelectedItem == null)
                return;
            if (eventListBox.SelectedIndex == 0)
            {
                MessageBox.Show("Zawarcia pierwszej umowy nie można usunąć");
                return;
            }
            if (eventListBox.SelectedItem.GetType() == typeof(WriteOffEvent))
            {
                MessageBox.Show("Automatycznie generowane zdarzenia nie mogą zostać usunięte");
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "Czy naprawdę chcesz usunąć wydarzenie: \n" + ((Event)(eventListBox.SelectedItem)).ToString(),
                "Usuwanie wydarzenia", 
                MessageBoxButtons.YesNo);

            if (dialogResult != DialogResult.Yes)
                return;

            ((Person)(personListBox.SelectedItem)).events.Remove((Event)eventListBox.SelectedItem);
            eventListBox.SelectedItem = null;
            Recount();
        }
        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save(); // Kod elementu "Zapisz"
        }
        private bool Save() // Kod uruchamiany po kliknięciu przycisku
        {
            bool status = false; 
            BinaryFormatter formatter = new BinaryFormatter();
            saveFileDialog1.ShowDialog();
            string saveFilePath = saveFileDialog1.FileName;
            if (saveFileDialog1.FileName != "")
            {
                using (FileStream fs = (FileStream)saveFileDialog1.OpenFile()) 
                {
                    formatter.Serialize(fs, addresses);
                    status = true;
                }
            }

            string md = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Rent Calculator";
            if (Directory.Exists(md) == false)
            {
                Directory.CreateDirectory(md); //tworzenie ręcznie wpisanego katalogu jeśli nie istnieje
            }
            if (Directory.Exists(md + "\\All backups") == false)
            {
                Directory.CreateDirectory(md + "\\All backups"); //tworzenie katalogu kopii zapasowych
            }
            saveFileDialog1.FileName = md + "\\All backups\\" + DateTime.Now.ToString("dd.MM.yyyy HH-mm") + ".dap"; //tworzenie kopii zapasowej z nazwa "data +" format pliku
            using (FileStream fs = (FileStream)saveFileDialog1.OpenFile())
            {
                formatter.Serialize(fs, addresses);
            }
            saveFileDialog1.FileName = md + "\\" + DateTime.Now.ToString("dd.MM.yyyy HH-mm") + ".dap";
            using (FileStream fs = (FileStream)saveFileDialog1.OpenFile())
            {
                formatter.Serialize(fs, addresses);
            }

            foreach (string str in Directory.GetFiles(md, "*.dap")) /*Sprawdzanie wybranego katalogu pod kątem istnienia plików z rozszerzeniem .dat
                                                                     * i zmiana nazwy zapisanego pliku na nazwę istniejącego*/
            {
                try
                {
                    string fileName = str.Substring(1 + str.LastIndexOf("\\"));
                    DateTime then = Convert.ToDateTime(fileName.Substring(0, 11));
                    if (DateTime.Now - then > new TimeSpan(60, 0, 0, 0, 0))
                    {

                        File.Delete(str); //usunięcie istniejącego pliku w celu zastąpienia go Nowym o tej samej nazwie
                    }
                }
                catch (Exception e)
                { }
            }
            saveFileDialog1.FileName = saveFilePath; // Zapisywanie projektu z wpisaną nazwą
            return status;
        }
        public void createNewItem(GenericNewHelper newSmth)
        {
            switch (newSmth)
            {
                case NewZamowHelper room:
                    Zamowienie newAddress = new Zamowienie(room.name, room.description);
                    addresses.Add(newAddress);
                    ZamowListBox.SelectedItem = newAddress;
                    personListBox.DataSource = newAddress.people;
                    currentZamowNameTextBox.Text = newAddress.name;
                    currentAddressDescriptionTextBox.Text = newAddress.description;
                    currentPersonNameTextBox.Text = "";
                    currentPersonDescriptionTextBox.Text = "";
                    //addressListBox.Items.Add(newAddress);
                    break;
                case NewPersonHelper personHelper:
                    Person person = new Person(personHelper.name, personHelper.description, personHelper.terms.dateOfAcceptance);
                    ((Zamowienie)ZamowListBox.SelectedItem).people.Add(person);
                    person.addEvent(new ContractChangeEvent(personHelper.terms.dateOfAcceptance, personHelper.endDate, personHelper.terms));
                    person.generateWithdrawEvents(DateTime.Now);
                    personListBox.SelectedItem = person;
                    eventListBox.DataSource = person.events;
                    currentPersonNameTextBox.Text = person.personName;
                    currentPersonDescriptionTextBox.Text = person.description;
                    break;
                case NewEventHelper new_event:
                    person = (Person)personListBox.SelectedItem;
                    if (person.addEvent(((NewEventHelper)newSmth).myEvent) == 1)
                        MessageBox.Show("Nie można wykonywać czynności przed" +
                            " zawarciem pierwszej umowy");
                    if (((NewEventHelper)newSmth).myEvent.GetType() == typeof(CustomWriteOff))
                    {
                        int i;
                        for (i = person.events.Count - 1;
                            i >= 0 &&
                            (person.events[i].GetType() != typeof(ContractChangeEvent) ||
                            person.events[i].date > ((NewEventHelper)newSmth).myEvent.date);
                            i--)
                            ;
                        ((CustomWriteOff)((NewEventHelper)newSmth).myEvent).penalty = ((ContractChangeEvent)person.events[i]).terms.penalty;
                    }
                    eventListBox.SelectedItem = ((NewEventHelper)newSmth).myEvent;
                    break;
            }
            Recount();
        }
        private void newEventButton_Click(object sender, EventArgs e)
        {
            if (personListBox.SelectedItem != null)
            {
                NewEvent test = new NewEvent(((Zamowienie)ZamowListBox.SelectedItem).name, ((Person)personListBox.SelectedItem).ToString());
                test.Owner = this;
                test.Show();
            }
        }
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e) // Kod elementu "Otworz"
        {
            BinaryFormatter formatter = new BinaryFormatter();
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "") // sprawdź, czy nie ma wpisanej nazwy otwieranego pliku
            {
                using (FileStream fs = (FileStream)openFileDialog1.OpenFile())
                {
                    BindingList<Zamowienie> newAddresses = (BindingList<Zamowienie>)formatter.Deserialize(fs);
                    addresses = newAddresses;
                    ZamowListBox.DataSource = addresses;
                }
            }

        }
        private void UnclickAllButtons()
        {
            changeCurrentAddressInfoButton_state = 0;
            changeCurrentPersonInfoButton_state = 0;
            changeCurrentAddressInfoButton.Text = "Zmienić";
            changeCurrentPersonInfoButton.Text = "Zmienić";
            currentZamowNameTextBox.Enabled = false;
            currentAddressDescriptionTextBox.Enabled = false;
            currentPersonNameTextBox.Enabled = false;
            currentPersonDescriptionTextBox.Enabled = false;

            if (ZamowListBox.SelectedItem != null)
            {
                Zamowienie address = (Zamowienie)ZamowListBox.SelectedItem;
                currentZamowNameTextBox.Text = address.name;
                currentAddressDescriptionTextBox.Text = address.description;
            }
            if (personListBox.SelectedItem != null)
            {
                Person person = (Person)personListBox.SelectedItem;
                currentPersonNameTextBox.Text = person.personName;
                currentPersonDescriptionTextBox.Text = person.description;
            }
        }
        private void changeCurrentAddressInfoButton_Click(object sender, EventArgs e)
        {
            if (changeCurrentAddressInfoButton_state == 0)
            {
                UnclickAllButtons();
                if (ZamowListBox.SelectedItem == null)
                    return;
                changeCurrentAddressInfoButton.Text = "Gotowe";
                currentZamowNameTextBox.Enabled = true;
                currentAddressDescriptionTextBox.Enabled = true;
                changeCurrentAddressInfoButton_state = 1;
            }
            else
            {
                if (ZamowListBox.SelectedItem == null)
                    return;
                Zamowienie address = (Zamowienie)ZamowListBox.SelectedItem;
                changeCurrentAddressInfoButton.Text = "Zmienić";
                address.name = currentZamowNameTextBox.Text;
                address.description = currentAddressDescriptionTextBox.Text;
                changeCurrentAddressInfoButton_state = 0;
                currentZamowNameTextBox.Enabled = false;
                currentAddressDescriptionTextBox.Enabled = false;
                ZamowListBox.DataSource = null;
                ZamowListBox.DataSource = addresses;
                ZamowListBox.SelectedItem = address;
            }
        }
        int changeCurrentPersonInfoButton_state = 0;
        private void changeCurrentPersonInfoButton_Click(object sender, EventArgs e)
        {
            if (changeCurrentPersonInfoButton_state == 0)
            {
                UnclickAllButtons();
                if (personListBox.SelectedItem == null)
                    return;
                changeCurrentPersonInfoButton.Text = "Gotowe";
                currentPersonNameTextBox.Enabled = true;
                currentPersonDescriptionTextBox.Enabled = true;
                changeCurrentPersonInfoButton_state = 1;
            }
            else
            {
                if (personListBox.SelectedItem == null)
                    return;
                Person person = (Person)personListBox.SelectedItem;
                changeCurrentPersonInfoButton.Text = "Zmienić";
                person.personName = currentPersonNameTextBox.Text;
                person.description = currentPersonDescriptionTextBox.Text;
                changeCurrentPersonInfoButton_state = 0;
                currentPersonNameTextBox.Enabled = false;
                currentPersonDescriptionTextBox.Enabled = false;
                personListBox.DataSource = null;
                personListBox.DataSource = ((Zamowienie)ZamowListBox.SelectedItem).people;
                personListBox.SelectedItem = person;
            }
        }
        private void countCurrentButton_Click(object sender, EventArgs e)
        {
            if (eventListBox.SelectedItem == null) // jeśli nie wybrane żadne zamówienie, przycisk nic nie robi
                return;
            Person person = (Person)personListBox.SelectedItem; 
            Report report = person.Simulate(curDateCalendar.SelectionStart);
            currentDebtTextBox.Text = report.totalDepth.ToString(); // po kliknięciu przycisk pokazuje ogólny Dług
            currentPenaltyTextBox.Text = report.totalPenalty.ToString(); // a takze Grzywna
            person.generateWithdrawEvents(DateTime.Now);
        }
        private void exportXLSButton_Click(object sender, EventArgs e)
        {

            if (personListBox.SelectedItem == null)  // jeśli nie wybrane żadne zamówienie, przycisk nic nie robi
                return;
            saveFileDialog2.ShowDialog(); // wyświetlanie okna dialogowego o zapisaniu pliku
            if (saveFileDialog2.FileName != "") // jeśli wpisana nazwa pliku nie jest pusta
            {
                IWorkbook workbook = new XSSFWorkbook(); // rozpoczynamy pracę z biblioteka IWorkbook
                workbook.CreateSheet("Sheet A1"); // utwórz nowy arkusz w pliku Excel
                XSSFSheet sheet = workbook.GetSheetAt(0) as XSSFSheet;
                IRow row = sheet.CreateRow(0); // Utwórz wiersz z trzema komórkami
                row.CreateCell(0).SetCellValue("Data"); 
                row.CreateCell(1).SetCellValue("Naliczone"); 
                row.CreateCell(2).SetCellValue("Opłacony"); 
                int curRow = 1;
                row = sheet.CreateRow(curRow); 
                foreach (Event curEvent in ((Person)personListBox.SelectedItem).events.Where( // pętla tworzenia wierszy dla każdego zdarzenia każdego użytkownika
                    x => { return x.date <= curDateCalendar.SelectionStart; }))
                {
                    if (curEvent.ToRow(row))
                    {
                        curRow++;
                        row = sheet.CreateRow(curRow);
                    }
                }
                Person person = (Person)personListBox.SelectedItem;
                Report report = person.Simulate(curDateCalendar.SelectionStart);
                sheet.AutoSizeColumn(0); // ustawia automatyczny rozmiar kolumny
                sheet.AutoSizeColumn(1);
                sheet.AutoSizeColumn(2);
                row.CreateCell(0).SetCellValue("Razem na" + curDateCalendar.SelectionStart.ToString().Substring(0, 11)); // zapisujemy komórkę z tekstem i danymi zaczerpniętymi z wpisów programu
                row.CreateCell(1).SetCellValue("Długi:");
                row.CreateCell(2).SetCellValue(report.totalDepth);
                row.CreateCell(3).SetCellValue("Grzywna:");
                row.CreateCell(4).SetCellValue(report.totalPenalty);
                row.CreateCell(5).SetCellValue("Długi+Grzywna:");
                row.CreateCell(6).SetCellValue(report.totalDepth + report.totalPenalty);
                for (int i = 0; i < 7; i++)
                    sheet.AutoSizeColumn(i);
                FileStream sw = File.Create(saveFileDialog2.FileName);
                workbook.Write(sw); // zapisujemy arkusz
                sw.Close(); // zamykamy arkusz

            }

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxContract_Enter(object sender, EventArgs e)
        {

        }

        private void currentEventTermPaymentUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
