using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pc_service_calc.Logics;

namespace pc_service_calc.Events
{
    [Serializable]
    public class PaymentChangeEvent : Event // Tworzenie klasy odpowiedzialnej za zdarzenie
    {
        public int payment; // inicjalizacja zmiennej
        public PaymentChangeEvent(DateTime newDate, int newPayment) : base("paymentChangeEvent", newDate)
        {
            payment = newPayment; 
        }
        public override string ToString()
        {
            return base.ToString() + "Zmiana płatności, teraz " + payment + "z."; // wiadomość-potwierdzenie
        }
        public override void Apply(Person person)
        {
            person.terms.payment = payment;
        }
    }
}
