using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trepårad
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardModel = new BoardModel();

            BoardView.Show(boardModel);
        }
    }
}
