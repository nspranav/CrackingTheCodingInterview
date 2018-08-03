using System;
using Collections;

namespace chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            var s  = new MyQueue<int>();
            s.Add(10);
            s.Add(20);
            Console.WriteLine("POPed element "+s.Remove());
            Console.WriteLine("POPed element "+s.Remove());
            s.PrintQueue();
        }
    }
}
