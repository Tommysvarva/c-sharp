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
        public void show()
        {
            Console.WriteLine(this.BirthYear);
        }
    }
}
   
