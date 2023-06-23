using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using pc_service_calc.Logics;

namespace pc_service_calc.Logics
{
    [Serializable]
    public class Zamowienie : Object // Klasa publiczna związana ze wszystkimi operacjami na danych Zamówienia
    {
        public string name; // inicjalizacja zmiennyh
        public string description;
        public BindingList<Person> people;
        public string GetName()
        {
            return name; // zwrot zmiennej "name"
        }
        public override string ToString()
        {
            return GetName(); // zwrot funkcji "GetName"
        }
        public Zamowienie(string newName, string newDescription)
        {
            name = newName; // inicjalizacja zmiennyh
            description = newDescription;
            people = new BindingList<Person>();
        }
    }
}
