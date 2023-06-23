using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPOI.SS.UserModel;
using pc_service_calc.Logics;

namespace pc_service_calc.Events
{
    [Serializable]
    public abstract class Event : Object
    {
        protected string type;
        public DateTime date;
        public DateTime getDate()
        {
            return date;
        }
        public string getType()
        {
            return type;
        }
        public Event(string newType, DateTime newDate)
        {
            type = newType;
            date = newDate;
        }
        abstract public void Apply(Person person);
        public virtual bool ToRow(IRow row)
        {
            row.CreateCell(0).SetCellValue(date.ToString().Substring(0, 11));
            return false;
        }
        public override string ToString()
        {
            return date.ToString().Substring(0, 10) + ": ";
        }
    }
}
