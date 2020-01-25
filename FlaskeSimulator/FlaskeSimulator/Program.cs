using System;
using System.Collections.Generic;


namespace FlaskeSimulator
{
    class Program
    {
        public static void Main(string[] args)
        {
            var bottle1 = new Bottle(10, 5);
            var bottle2 = new Bottle(20, 3);
            var totalVolume = 5;
            Console.WriteLine($"bottle1 capacity = {bottle1.capacity}");
            Console.WriteLine($"bottle1 content = {bottle1.content}");
            Console.WriteLine($"bottle2 capacity = {bottle2.capacity}");
            Console.WriteLine($"bottle2 content = {bottle2.content}");
            bottle1.FillFlask();
        }
    }
}
