using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pc_service_calc.Logics;

namespace pc_service_calc.Events
{
    [Serializable]
    public class PenaltyEvent : Event // Tworzenie klasy odpowiedzialnej za zdarzenie
    {
        public PenaltyEvent(DateTime newDate) : base("penaltyEvent", newDate)
        {
        }
        public override void Apply(Person person)
        {
            foreach (MonthBill month in person.months)
            {
                month.penalty += month.debt * month.penaltyPercentage; // obliczenie Grzywny
            }
        }
    }
}
