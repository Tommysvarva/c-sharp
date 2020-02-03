using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StartListe
{
    class Program
    {

        static void Main(string[] args)
        {
            var listOfRegistration = new List<Registration>();
            var clubs = new List<Club>();

            using (var file = new StreamReader("startlist.csv"))
            {
                string line;
                while (true)
                {
                    line = file.ReadLine();
                    var linePart = line.Split(',').Select(n => n.Trim('"')).ToArray();
                    var registration = new Registration(linePart);
                    listOfRegistration.Add(registration);

                    var club = clubs.SingleOrDefault(c => c.ClubName == registration.Club.Trim());
                    if (club == null)
                    {
                        club = new Club(registration.Club);
                        clubs.Add(club);
                    }
                    club.AddToClubRegistrations(registration);
                }


            }
        
        }
        
    }
}
