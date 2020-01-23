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

            while (true)
            {
                
                BoardView.Show(boardModel);
                Console.WriteLine("Skriv inn hvor du vil sette kryss (f.eks. \"a2\"): ");
                var position = Console.ReadLine();
                var col = position[0] - 'a'; // eks a = 1    b = 2   c = 3
                var row = position[1] - '1'; // 1    
                var index = row * 3 + col; // 3   eks c3  2*3 +2 = 8
                boardModel.SetCross(index);
                BoardView.Show(boardModel);
                return ;
            }
        }
    }
}
