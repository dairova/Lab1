using System;

namespace Task1
{
    class Program
    {
        //create a boolean function (returns true or false)  
        static bool IsPrime(int p)
        {
            //if the number p is equal to 1, return false
            if (p == 1)
                return false;

            //create a cycle starting from 2 to the number p (because the condition k = 1 has already been considered)
            for (int k = 2; k < p; k++)
            {
                //if the number is left without remainder (when dividing by divisor), then return false 
                if (p % k == 0)
                    return false;
            }
            //return true, if previous conditions are not executed
            return true;
        }

        static void Main(string[] args)
        {
            //declare variable n
            string n;

            //read the first line from the console
            n = Console.ReadLine();

            //convert string to integer
            int b = int.Parse(n);

            /*
              create an array based on the string (that read from the console),
              divided into parts based on (space) using the "Split"
            */
            string[] a = Console.ReadLine().Split();

            //create an array that consists of the quantity of b
            int[] array = new int[b];

            //create loop to convert the previous array to integer
            for (int j = 0; j < b; j++)
            {
                array[j] = int.Parse(a[j]);
            }

            //declare variable that counts the amount of prime numbers
            int cnt = 0;

            /*
             create a loop based on a function that increase the variable cnt if condition is true
             */
            for (int j = 0; j < b; j++)
            {
                //condition: if the function returns true
                if (IsPrime(array[j]) == true)
                {

                    //count quantaty of prime numbers
                    cnt++;
                }
            }

            //output the amount of prime numbers in console
            Console.WriteLine(cnt);

            /*   
             create a loop based on a function that displays the number that follows conditions
             */
            for (int j = 0; j < b; j++)
            {
                //condition: if the function returns true
                if (IsPrime(array[j]) == true)

                    //display prime number to console
                    Console.Write(array[j] + " ");
            }
            Console.ReadKey(true);
        }

    }
}
