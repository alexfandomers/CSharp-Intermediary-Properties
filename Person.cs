using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntermediaryProperties
{
    
    public class Person
    {
        //(3)constructor to access private set
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        //(1)auto implemented property without declare a field
       //with this code c# internaly create a private field and inplement a get and set access
       public DateTime Birthdate {get; private set;}//need a constructor to access private set

       //(2)age property(i want this field to be based on the birthdate)
       //if a declare it like this: public int Age{get; set;} it will not be based on birthdate
       //instead we gonna do is create a get access and do some logic like below
       //this property calculate age based on the value of other property
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