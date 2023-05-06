using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ifElsePracrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (10 > 8)
            {
                Console.WriteLine("this is true");  // print will be "this is true"
            }
            if (10 == 5*2) 
            {
                Console.WriteLine('T');             // print will be 'T'
             }
            if (10 == 4+2) 
            {
                Console.WriteLine("False"); // this is 'false' that's why nothing gonna be printed
            }
                      //////////////////////////////////////////////
                      

            int X = 5;
            int Y = 6;
            int Z = 7;


            if (Y % X == 1)                 
            {
                Console.WriteLine("My");              // True
            }
            
            if (Y - X == 1) 
            {
                Console.WriteLine("Name");            // True
            }
            
            
            if (Z > Y)
            {
                Console.WriteLine("is");              // True
            }
            
            
            if (Y - X >= 0) 
            {
                Console.WriteLine("MOkbul");          // True
            }
            
            
            if (Y + Z < 20)
            {
                Console.WriteLine("Hossan");          // True
            }
            
            
            if (X / Y == Z)
            {
                Console.WriteLine("showed Nothing");  // False
            }



            ///////////////////////////////


            if (Y % X == 1)
            {
                Console.Write ("My ");              // True
            }

            if (Y - X == 1)
            {
                Console.Write (" Name ");            // True
            }


            if (Z > Y)
            {
                Console.Write (" is ");              // True
            }


            if (Y - X >= 0)
            {
                Console.Write (" MOkbul ");          // True
            }


            if (Y + Z < 20)
            {
                Console.WriteLine (" Hossan ");          // True
            }





        }
    }
}
