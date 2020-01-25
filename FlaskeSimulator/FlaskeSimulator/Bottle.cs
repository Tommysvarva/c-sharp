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

        public void FillFlaskToTop()
        {
            content = capacity;
            Console.WriteLine(content);
        }

        public void FillFlaskWith( int amount)
        {
            content = Math.Min(content + amount, capacity);
        }
        public int EmptyFlask()
        {
            var currentContent = content;
            content = 0;
            return currentContent;
        }

    }
}
