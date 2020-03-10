using System;
using System.Collections.Generic;
using NET_TRAINING.Process;

namespace NET_TRAINING
{
    class Program
    {
        static void Main(string[] args)
        {
            User a = new User(); // 123
            a.Name = "AN";
            a.Display();
            User b = new User(a.Name); // => 123
            b.Display();
            var c = b; // => 123
            c.Display();
            a.Name = "DIeu";
            a.Display();
            b.Display();
            c.Display();
            b.Name = "Jacob";
            a.Display();
            b.Display();
            c.Display();
            c.Display();
            int ia = 1;
            Console.WriteLine(ia); // = 1
            int ib = ia;


            Console.WriteLine(ib); // = 1
            int ic = ib;
            Console.WriteLine(ic);// = 1
            ia = 2;
            Console.WriteLine(ia); // = 2
            Console.WriteLine(ib); // = 1
            Console.WriteLine(ic); // = 1
        }
    }
}
