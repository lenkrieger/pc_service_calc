using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pc_service_calc.Logics;

namespace pc_service_calc.Events
{
    [Serializable]
    public class LeaveEvent : Event // Tworzenie klasy odpowiedzialnej za zdarzenie
    {
        public LeaveEvent(DateTime newDate) : base("leaveEvent", newDate)
        {

        }
        public override string ToString()
        {
            return base.ToString() + "Zamówienie zamknięte"; // wiadomość-potwierdzenie
        }
        public override void Apply(Person person)
        {
            person.status = 0; // Zmiana statusu klienta
        }
    }
}
