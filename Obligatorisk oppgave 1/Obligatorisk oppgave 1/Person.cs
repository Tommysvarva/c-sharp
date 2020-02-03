using System;
using System.Collections.Generic;

namespace Obligatorisk_oppgave_1
{
    public class Person
    {
        public int Id { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public int BirthYear { get; internal set; }
        public Person Father { get; internal set; }
        public Person Mother { get; internal set; }


        public Person()
        {
          
        }
        //public void Show()
        //{
        //    Console.WriteLine($"Firstname =  {FirstName} ");
        //    if (LastName != null) Console.WriteLine($"Lastname =  {LastName} ");
        //    Console.WriteLine($"Birthyear =  {BirthYear}");
        //    if (Mother != null) Console.WriteLine($"Mother =  {Mother.FirstName} id={Mother.Id}");
        //    if (Father != null) Console.WriteLine($"Father =  {Father.FirstName} id={Father.Id}");
        //    Console.WriteLine($"Id =  {Id}");
        //    Console.WriteLine("\n");
        //    Console.WriteLine("---------------------------------------");
        //    Console.WriteLine("\n");

        //}
        public void Show(List<Person> list)
        {

            Console.WriteLine($"Firstname =  {FirstName} ");
            if (LastName != null) Console.WriteLine($"Lastname =  {LastName} ");
            Console.WriteLine($"Birthyear =  {BirthYear}");
            if (Mother != null) Console.WriteLine($"Mother =  {Mother.FirstName} id = {Mother.Id}");
            if (Father != null) Console.WriteLine($"Father =  {Father.FirstName} id = {Father.Id}");
            Console.WriteLine($"Id =  {Id}");


        }

        //private void ifMotherOrFatherPrintInfo(List<Person> list)
        //{
        //    for (var i = 0; i < list.Count ; i++)
        //    {
        //        if (list[i].Mother != null)
        //        {
        //            if (FirstName == list[i].Mother.FirstName)
        //            {
        //                Console.WriteLine($"Child: FirstName = {list[i].FirstName}  Id = {list[i].Id}");
        //                continue;
        //            }
                  
        //        }
        //        if (list[i].Father != null)
        //        {
        //            if (FirstName == list[i].Father.FirstName)
        //            {
        //                Console.WriteLine($"Child:{list[i].FirstName}  Id = {list[i].Id}");
        //                continue;
        //            }
        //        }

        //    }
        }
    }

    

   
