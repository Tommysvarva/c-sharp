using System;
using System.Collections.Generic;



namespace Obligatorisk_oppgave_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var showPersons = CreatePersons();
            initiateWelcomeText();
            while (true)
            {
                Console.WriteLine("Type in you command...");
                var option = Console.ReadLine();
                if (option == "hjelp")
                {
                    initiateWelcomeText();

                }
                else if (option == "liste")
                {
                    for (var i = 0; i <= showPersons.Count - 1; i++)
                    {
                        showPersons[i].Show(showPersons);
                        ifMotherOrFatherPrintInfo(showPersons, i);
                    }
                }
                else if (option.Length >= 7)
                {
                    ShowPersonsBasedOnId(option, showPersons);

                }
                else
                {
                    Console.WriteLine("Type in you command...");
                    
                }
            }
        }
      
        private static void ShowPersonsBasedOnId(string option, List<Person> showPersons)
        {
            if (option.Length == 7) {
                var id = Convert.ToInt32(option.Substring(5, 1)) - 1;
                showPersons[id].Show(showPersons);
                ifMotherOrFatherPrintInfo(showPersons,id);


            }
            else if (option.Length == 8) { var id = Convert.ToInt32(option.Substring(5, 2)) -1;
                showPersons[id].Show(showPersons);
                ifMotherOrFatherPrintInfo(showPersons, id);

            } 

        }

        public static List<Person> CreatePersons()
        {
            var sverreMagnus = new Person { Id = 1, FirstName = "Sverre Magnus", BirthYear = 2005 };
            var ingridAlexandra = new Person { Id = 2, FirstName = "Ingrid Alexandra", BirthYear = 2004 };
            var haakon = new Person { Id = 3, FirstName = "Haakon Magnus", BirthYear = 1973 };
            var metteMarit = new Person { Id = 4, FirstName = "Mette-Marit", BirthYear = 1973 };

            var marius = new Person { Id = 5, FirstName = "Marius", LastName = "Borg Høiby", BirthYear = 1997 };
            var harald = new Person { Id = 6, FirstName = "Harald", BirthYear = 1937 };
            var sonja = new Person { Id = 7, FirstName = "Sonja", BirthYear = 1937 };
            var olav = new Person { Id = 8, FirstName = "Olav", BirthYear = 1903 };

            sverreMagnus.Father = haakon;
            sverreMagnus.Mother = metteMarit;
            ingridAlexandra.Father = haakon;
            ingridAlexandra.Mother = metteMarit;
            marius.Mother = metteMarit;
            haakon.Father = harald;
            haakon.Mother = sonja;
            harald.Father = olav;

            var list = new List<Person> { 
            sverreMagnus, ingridAlexandra, haakon, metteMarit, marius, harald, sonja, olav
            };

            return list;

        }
        public static void ifMotherOrFatherPrintInfo(List<Person> list, int Id)
        {
            for (var i = 0; i < list.Count; i++)
            {

                if (list[i].Mother != null)
                {
                    if (list[Id].FirstName == list[i].Mother.FirstName)
                    {
                        Console.WriteLine($"Child: FirstName = {list[i].FirstName}  Id = {list[i].Id}");
                        continue;
                    }

                }
                if (list[i].Father != null)
                {
                    if (list[Id].FirstName == list[i].Father.FirstName)
                    {
                        Console.WriteLine($"Child:{list[i].FirstName}  Id = {list[i].Id}");

                  
                        continue;
                    }
                }

            }
        }


            static void initiateWelcomeText()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Velkommen til applikasjonen!");
            Console.WriteLine("Her ville du kunne finne informasjon om det kongelige slektstreet.");
            Console.WriteLine("\n");
            Console.WriteLine("---------------------------------------------------------------------");
            showInformationText();
        }

        private static void showInformationText()
        {
            Console.WriteLine("Du har følgende kommandoer å velge mellom:");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("hjelp: Viser alle tilgjengelige kommandoer.");
            Console.WriteLine("liste: Viser en liste med alle personer i databasen med deres informasjon");
            Console.WriteLine("vis <id>: Viser en bestemt person(id) med mor, far og barn (og id for disse).");
            Console.WriteLine("\n");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Skriv en kommando for å forsette...");
        }
    }
}
