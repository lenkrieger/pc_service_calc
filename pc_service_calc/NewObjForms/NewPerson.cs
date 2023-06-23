using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pc_service_calc.Logics;

namespace pc_service_calc.NewObjectForms
{
    public partial class NewPerson : AbstractNew // tworzenie nowej klasy odpowiedzialnej za inicjowanie interfejsu i tworzenie nowego rekordu
    {
        public NewPerson() : base()
        {
            InitializeComponent(); // inicjalizacja głównego interfejsu okna
        }
        public NewPerson(string zamow) : base()
        {
            InitializeComponent(); //inicjalizacja interfejsu wyświetlanych informacji o zamówieniu i kalendarzy, z datami rozpoczęcia umowy  
            label11.Text = zamow;  
            endTermMonthCalendar.MinDate = startTermMonthCalendar.SelectionStart; 
        }
        protected override GenericNewHelper getContents()
        {
            if (nameTextBox.Text.Length < 3) // sprawdzanie długości imienia i nazwiska klienta
                return new ErrorHelper("", "Wpisz imię i nazwisko więcej niż 3 litery");
            if (endTermMonthCalendar.SelectionStart <= startTermMonthCalendar.SelectionStart) // sprawdzenie poprawności wprowadzenia daty umowy
                return new ErrorHelper("", "Umowa kończy się wcześniej niż zaczyna"); 
            return new NewPersonHelper( // tworzenie nowego wpisu 
                nameTextBox.Text,
                descriptionTextBox.Text,
                startTermMonthCalendar.SelectionStart,
                endTermMonthCalendar.SelectionStart,
                (int)rentSumUpDown.Value, 
                (int)paymentDayUpDown.Value,
                (double)penaltyUpDown.Value);
        } 
        private void endTermMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            endTermMonthCalendar.MinDate = startTermMonthCalendar.SelectionStart; // kalendarz, z datami zakończenia umowy  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewPerson_Load(object sender, EventArgs e)
        {

        }
    }
    public class NewPersonHelper : GenericNewHelper // Klasa publiczna przechowująca sobie zmienne związane z Umową i informacją klienta
    {
        public Terms terms;
        public DateTime endDate;
        public NewPersonHelper(
            string name, 
            string description,
            DateTime newDate, 
            DateTime newEndDate,
            int newRent, 
            int day, 
            double newPenalty) : base(name, description)
        {
            endDate = newEndDate;
            DateTime payDay = new DateTime(newDate.Year, newDate.Month, day);
            if (payDay < newDate)
                payDay = payDay.AddMonths(1);
            terms = new Terms(newRent, newDate, payDay, newPenalty);
        }
    }
}
