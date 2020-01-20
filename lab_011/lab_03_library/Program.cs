﻿using System;
using lab_03_library_files;

namespace lab_03_use_library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is going to call and use a library");
            // OOP: new 'instance' to talk to class
            var myinstance = new MyClass();
            Console.WriteLine(myinstance.DoubleUp(10));
            Console.WriteLine(myinstance.GravitationalConstant);

            Console.WriteLine("now referencing Static items");
            Console.WriteLine(MyClass.AlsoTripleUp(10));
            Console.WriteLine(MyClass.NaturalLogarithmE);

        }
    }
}
