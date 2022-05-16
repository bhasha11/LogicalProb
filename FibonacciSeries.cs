using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problem
{
    public class FibonacciSeries
    {
       
        
            public int Number1 = 0;
            public int Number2 = 1;
            public int Number3;
            public int i;
            public int ReadNumber;
            public void CheckFibonacciSeries()
            {

                Console.Write("Enter the number of elements: "); //Input From User
                ReadNumber = int.Parse(Console.ReadLine()); //Read Number 
                Console.WriteLine(Number1 + " " + Number2 + " "); //printing 0 and 1    
                for (i = 2; i < ReadNumber; ++ i) //loop starts from 2 because 0 and 1 are already printed    
                {
                    Number3 = Number1 + Number2; //adding Number1 + Number 2 and stroe it in Number 3
                    Console.WriteLine(Number3 + " ");  // print Number3
                    Number1 = Number2; //assign value
                    Number2 = Number3;//assign value
                }

            }
        }
    }


