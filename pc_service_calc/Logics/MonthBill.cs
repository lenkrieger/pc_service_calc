using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pc_service_calc.Logics
{
    [Serializable]
    public class MonthBill : Object
    {
        public DateTime date;
        public double debt;
        public double penalty;
        public double penaltyPercentage;
        public MonthBill(DateTime newDate, double newDebt, double newPenaltyPercentage)
        {
            debt = newDebt;
            date = newDate;
            penaltyPercentage = newPenaltyPercentage;
        }
    }
}
