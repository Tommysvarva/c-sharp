using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartListe
{
    class Club
    {
        public string ClubName { get; set; }
        public List<Registration> ClubRegistrations { get; }

        // Jeg må lage en lite som jeg kan legge til i :) En metode som tar inn noe jeg skal legge til i en liste over registrerte.
        public Club(string clubName)
        {
            ClubName = clubName;
            ClubRegistrations = new List<Registration>();
        }
  
        public void AddToClubRegistrations(Registration registration)
        {
            ClubRegistrations.Add(registration);
        }
    }
}
