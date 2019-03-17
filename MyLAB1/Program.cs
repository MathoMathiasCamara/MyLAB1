using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLAB1
{
    class Program
    {
        static void Main(string[] args)
        {
           //my local variables
            CubicOperation Operation1 = new CubicOperation();
            int a = 4, b = 9;

            //operations
            Console.Write("the cube function of the difference of two integers:\n\n");
           
            Operation1.NumberOne = a;          
            Operation1.NumberTwo = b;

            Console.Write("-----Difference-----\n");
            Console.Write("{0}-{1}={2}\n", Operation1.NumberOne, Operation1.NumberTwo,Operation1.Substraction());

            Console.Write("----- Results of the cubic operation (a-b)^3  :-----\n");
            Console.Write("{0}\n\n", Operation1.Cube());

            Console.Write("Your initial values are:\n");
            Console.Write("a={0}\nb={1}", Operation1.NumberOne,Operation1.NumberTwo);
            Console.Read();
        }
    }
}
