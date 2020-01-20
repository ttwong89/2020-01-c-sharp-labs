using System;

namespace lab_03_library_files
{
    

    public class MyClass //class is a container
    {
        public int DoubleUp(int number) //method (function)
        { 
            
            return 2* number;

        }

        public double GravitationalConstant = 9.81;

        public static int AlsoTripleUp(int number) //read directly from class
        {
            return 3 * number;
        }
        //field
        public static double NaturalLogarithmE = 2.71;
    }
}
