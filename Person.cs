using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntermediaryProperties
{
    public class Person
    {
        //propertie name
        public string name{ get; set; }
        //propety datetime
        public DateTime Birthdate {get; private set; }//private set can read only - can not changed

        //constructor that makes birthdate acessible
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        //property declared below
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days/365;

                return years;
            }
        }
    }
}