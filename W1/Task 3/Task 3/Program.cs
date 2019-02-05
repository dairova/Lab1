using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variable
            string n; 
            //read the line from the console
            n = Console.ReadLine(); 
            //convert string to integer
            int b = int.Parse(n); 

            /*create an array based on the string,
              and divide the string into parts using the "Split"
             */
            string[] arr = Console.ReadLine().Split();

            //create a loop to output array elements (repeating each element)
            for (int i = 0; i < b; i++) 
            {
                Console.Write(arr[i] + " " + arr[i] + " ");
                Console.ReadKey(true);
            }
        }
    }
}
 