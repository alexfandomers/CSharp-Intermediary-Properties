using System;

namespace IntermediaryProperties
{
    public class Program
    {
        static void Main(string[] args)
        {
            //a property is a kind of a class menber that is used for providing access to fields of a class
            //as a best practice, we must declare fields as private and create public properties to provide access to them.

            var person = new Person(new DateTime(1982, 1, 1));
            //birthdate was set as private(neeed a constructor to fix it)
            //person.Birthdate = new DateTime(1982, 1, 1); (if birthdate wasn't private)
            Console.WriteLine(person.Age);
        }
    }
}
