using System;
using System.Collections.Generic;
using System.Linq;


namespace Obligatorisk_oppgave_1
{
    public class Person
    {
        public int Id { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public int BirthYear { get; internal set; }
        public object Father { get; internal set; }
        public object Mother { get; internal set; }


        public Person()
        {
          
        }
        public void Show()
        {
           
            Console.WriteLine($"Firstname =  {FirstName} ");
            Console.WriteLine($"Lastname =  {LastName} ");
            Console.WriteLine($"Birthyear =  {BirthYear}");
            Console.WriteLine($"Mother =  {Mother}");
            Console.WriteLine($"Father =  {Father}");
            Console.WriteLine($"Id =  {Id}");
            Console.WriteLine("\n");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\n");

        }
    }
}
   
