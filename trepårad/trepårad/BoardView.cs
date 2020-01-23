using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
namespace trepårad
{
    class BoardView
    {
        public static void Show(BoardModel m)
        {
            Console.Clear();
            Console.WriteLine(
                "  a b c\n" +
                " ┌─────┐\n" +
                "1│" + "0" + " " + " " + " " + " " + "│\n" +
                "2│" + " " + " " + " " + " " + "0" + "│\n" +
                "3│" + "X" + " " + "X" + " " + " " + "│\n" +
                " └─────┘");
            
        }

        //private static char GetChar(BoardModel boardmodel, int index)
        //{
        //    var cell = boardModel.Cells[index];
        //}
    }
}
