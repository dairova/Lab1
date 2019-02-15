using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string n; //declare variable for 2d array 

            n = Console.ReadLine(); //read the string from the console
            int b = int.Parse(n); //convert string to integer

            for (int i = 1; i <= b; i++) //create loop (for row of array)
            {
                for (int j = 1; j <= b; j++) //creatw loop (for column of array)
                {
                    /* to make a triangle consisting of [*] this condition should be followed:
                     the row number must be greater than or equal to the column number of the array
                     */

                    if (i >= j)
                    {
                     //output [*] as an element of the array if the condion is implemented
                        Console.Write("[*]"); 
                    }
                }
                //print a space where the condition is not implemented
                Console.WriteLine();
            }
            Console.ReadKey();// used to show the result until the window did not close
        }
    }
}

