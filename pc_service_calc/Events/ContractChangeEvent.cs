using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pc_service_calc.Logics;

namespace pc_service_calc.Events
{
    [Serializable]
    public class ContractChangeEvent : Event // Tworzenie event odpowiedzialnego za zmianę danych oprogramowania w umowie
    {
        public Terms terms; // inicjalizacja zmiennych
        public DateTime endDate;
        public ContractChangeEvent(DateTime newDate, DateTime newEndDate, Terms newTerms) : base("contractChangeEvent", newDate)
        {
            endDate = newEndDate; // zmiana dziwnych zmiennych na nowe
            terms = newTerms;
        }
        public override string ToString()
        {
            return base.ToString() + "Zawarta umowa"; // wiadomość-potwierdzenie
        }
        public override void Apply(Person person)
        {
            person.terms = new Terms(terms.payment, terms.dateOfAcceptance, terms.dayOfPayment, terms.penalty); // stosowanie zmian
            person.status = 1;
        }
    }
}
