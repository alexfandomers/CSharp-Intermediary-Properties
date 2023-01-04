using System;
 //a way to access a private atribute
 //A property is a class menber that encapsulates a getter/setter for accessing a field.
 //We nedd a property to create a getter/setter with less code
namespace IntermediaryProperties
{
    public class Program
    {
        static void Main(string[] args)
        {
           var person = new Person(new DateTime(1982, 1, 1));
           //person.Birthdate = new DateTime(1982, 1, 1); //now the constructor has parameters
           System.Console.WriteLine(person.Age);
        }
    }
}
