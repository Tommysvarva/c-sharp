using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartListe
{
    class Registration
    {
        public int StartNumber { get; set; }
        public string Name { get; set; }
        public string Club{ get; set; }
        public string Nationality { get; set; }
        public string Group { get; set; }
        public string Class { get; set; }

        public Registration(string[] values)
        {
            var success = int.TryParse(values[0], out var number);
           
            //StartNumber = values[];
            Name = values[1];
            Club = values[2];
            Nationality = values[3];
            Group = values[4];
            Class = values[5];
        }
    }
    
}
