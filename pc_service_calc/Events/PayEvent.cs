using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPOI.SS.UserModel;
using pc_service_calc.Logics;

namespace pc_service_calc.Events
{
    [Serializable]
    public class PayEvent : Event // Tworzenie klasy odpowiedzialnej za zdarzenie
    {
        public int moneyPaid; // inicjalizacja zmiennej
        public override bool ToRow(IRow row) // kod wykonywany podczas eksportowania danych
        {
            base.ToRow(row);
            row.CreateCell(2).SetCellValue(moneyPaid); 
            return true;
        }
        public PayEvent(DateTime newDate, int money) : base("payEvent", newDate)
        {
            moneyPaid = money; 
        }
        public override string ToString()
        {
            return base.ToString() + "Opłacono " + moneyPaid + "z."; // wiadomość-potwierdzenie
        }
        public override void Apply(Person person)
        {
            int curMoney = moneyPaid + person.overpayment;
            while (curMoney > 0 && person.months.Count > 0) // Kontrola nadpłaty, w przypadku jej, sprawdzenie, czy istnieje dług do spłaty, kontynuacja umowy lub zwrot nadpłaty
            {
                if (curMoney > person.months[0].debt)
                {
                    curMoney -= (int)Math.Round(person.months[0].debt);
                    person.months[0].debt = 0;
                }
                else
                {
                    person.months[0].debt -= curMoney;
                    curMoney = 0;
                }
                if (curMoney > person.months[0].penalty)
                {
                    curMoney -= (int)Math.Round(person.months[0].penalty);
                    person.months[0].penalty = 0;
                }
                else
                {
                    person.months[0].penalty -= curMoney;
                    curMoney = 0;
                }
                if (person.months[0].debt == 0 && person.months[0].penalty == 0)
                    person.months.RemoveAt(0);
            }
            if (curMoney > 0)
                person.overpayment = curMoney;
        }
    }
}
