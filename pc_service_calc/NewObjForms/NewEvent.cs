using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pc_service_calc.Events;
using pc_service_calc.Logics;

namespace pc_service_calc.NewObjectForms
{
    public partial class NewEvent : AbstractNew
    {
        GroupBox[] groupBoxes;
        public NewEvent(string zamow, string person) : base()
        {
            InitializeComponent(); // inicjalizacja fragmentów interfejsu 
            zamowLabel.Text = zamow; 
            personLabel.Text = person;
            eventTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; // kod odpowiadający za typ i wygląd "DropBox"
            groupBoxes = new GroupBox[] { // grupowanie elementów
                paymentGroupBox,
                newTermsGroupBox,
                leaveGroupBox,
                newPaymentSetGroupBox,
                customWriteOffGroupBox };
            eventTypeComboBox.SelectedIndex = 0;
            termsEndMonthCalendar.MinDate = eventDateMonthCalendar.SelectionStart;
        }
        protected override GenericNewHelper getContents()
        {

            Event myEvent;
            switch (eventTypeComboBox.SelectedIndex) // "SwichBox", aby wybrać jedną z kilku opcji zdarzeń, z których każda wywołuje odpowiedni Event
            {
                case 0:
                    myEvent = new PayEvent(eventDateMonthCalendar.SelectionStart, (int)paymentSumUpDown.Value); 
                    break;
                case 1:
                    DateTime newDate = eventDateMonthCalendar.SelectionStart;
                    DateTime endDate = termsEndMonthCalendar.SelectionStart;
                    DateTime payDay = new DateTime(newDate.Year, newDate.Month, (int)payDateUpDown.Value);
                    if (payDay < newDate)  
                        payDay = payDay.AddMonths(1);
                    myEvent = new ContractChangeEvent(
                        newDate, 
                        endDate, 
                        new Terms((int)newTermsPaymentUpDown.Value, 
                            newDate,
                            payDay, 
                            (double)newTermsPenaltyUpDown.Value));
                    break;
                case 2:
                    myEvent = new LeaveEvent(eventDateMonthCalendar.SelectionStart); 
                    break;
                case 3:
                    myEvent = new PaymentChangeEvent(eventDateMonthCalendar.SelectionStart, (int)newPaymentUpDown.Value);
                    break;
                case 4:
                    myEvent = new CustomWriteOff(
                        eventDateMonthCalendar.SelectionStart, 
                        (int)customWriteOffSumUpDown.Value,
                        0,
                        customWriteOffCommentTextBox.Text);
                    break;
                default: 
                    myEvent = new LeaveEvent(eventDateMonthCalendar.SelectionStart); // opcja wybrana domyślnie po otwarciu okna
                    break;
            }
            return new NewEventHelper(myEvent);
        }

        private void eventTypeComboBox1_SelectedIndexChanged(object sender, EventArgs e) // kod odpowiedzialny za wyświetlanie i ukrywanie elementu, w zależności od wyboru przez użytkownika jednej z opcji wydarzenia
        {
            foreach (GroupBox i in groupBoxes)
            {
                i.Visible = false;
                i.Enabled = false;
            }
            groupBoxes[eventTypeComboBox.SelectedIndex].Visible = true;
            groupBoxes[eventTypeComboBox.SelectedIndex].Enabled = true;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            termsEndMonthCalendar.MinDate = eventDateMonthCalendar.SelectionStart;
        }

        private void customWriteOffGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
    public class NewEventHelper : GenericNewHelper
    {
        public Event myEvent;
        public NewEventHelper(Event newEvent) : base("", "")
        {
            myEvent = newEvent;
        }
    }
}
