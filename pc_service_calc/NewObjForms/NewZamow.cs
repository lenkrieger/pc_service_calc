using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pc_service_calc.NewObjectForms
{
    public partial class NewZamow : AbstractNew // tworzenie nowej klasy odpowiedzialnej za inicjowanie interfejsu i tworzenie nowego rekordu
    {
        public NewZamow() : base()
        {
            InitializeComponent(); // inicjalizacja interfejsu, wywołanie okna
        }
        protected override GenericNewHelper getContents()
        {
            if (addressNameTextBox.Text.Length < 3) // sprawdzanie długości nazwy, nie może być mniejsza niż 3 znaki
                return new ErrorHelper("", "Długość nazwy powinna być większa niż 3 litery");
            return new NewZamowHelper(addressNameTextBox.Text, addressDescriptionTextBox2.Text);
        }

        private void NewZamow_Load(object sender, EventArgs e)
        {

        }
    }
    public class NewZamowHelper : GenericNewHelper
    {
        public NewZamowHelper(string name, string description) : base(name, description) // tworzenie nowego wpisu
        {
        }
    }
}
