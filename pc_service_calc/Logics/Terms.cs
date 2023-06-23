using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pc_service_calc.Logics
{
    [Serializable]
    public class Terms : Object
    {
        public int payment;
        public DateTime dateOfAcceptance;
        public DateTime dayOfPayment;
        public DateTime dateOfEnd;
        public double penalty;
        public Terms(int newPayment, DateTime newDateOfAcceptance, DateTime newDayOfPayment, double newPenalty)
        {
            payment = newPayment;
            dateOfAcceptance = newDateOfAcceptance;
            dayOfPayment = newDayOfPayment;
            penalty = newPenalty;
        }
        public Terms(int newPayment,
            DateTime newDateOfAcceptance,
            DateTime newDayOfPayment,
            double newPenalty,
            DateTime newDateOfEnd)
        {
            payment = newPayment;
            dateOfAcceptance = newDateOfAcceptance;
            dayOfPayment = newDayOfPayment;
            penalty = newPenalty;
            dateOfEnd = newDateOfEnd;
        }
    }
}
