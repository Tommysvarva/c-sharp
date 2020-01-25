using System;
using System.Collections.Generic;


namespace FlaskeSimulator
{
    public class Bottle
    {
        public int capacity;
        public int content;
        public Bottle(int capacityValue, int contentValue)
        {
            this.capacity = capacityValue;
            this.content = contentValue;
        }

        public void FillFlask()
        {
            content = capacity;
            Console.WriteLine(content);

        }
    }
}
