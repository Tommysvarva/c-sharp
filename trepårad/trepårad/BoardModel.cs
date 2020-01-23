using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trepårad
{

    class BoardModel
    {
        public CellModel[] Cells { get; }
        private readonly Random _random;

        public BoardModel ()
        {
            Cells = new CellModel[9]; // Vi definerer et array med 9 plasser uten noen verdi.

            for (var i = 0; i < Cells.Length; i++ )
            {
                Cells[i] = new CellModel(); // Setter verdien i hver enkelt posisjon til å være et CellModel object.
            }
            _random = new Random();
        }
        public void AddDummyData()
        {
            Cells[0].Mark(true); // Caller methoden Mark() med verdien true;
            Cells[1].Mark(false);                                           
        }
        
        public void SetCross(int index)
        {
            Cells[index].Mark(true);
        }
    }
}
