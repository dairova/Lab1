using System;
using System.IO;

namespace Task_2_2t
{
    class Program
    {
        static bool IsPrime(int p)
        {
            //if the number p is equal to 1, then return false
            if (p == 1)
                return false;

            //create cycle from 0 to the number p, because 1 is already checked
            for (int k = 2; k < p; k++)
            {
                // if the number p is dividing by divisor without remainder, then return false
                if (p % k == 0)
                    return false;
            }
            //return true if all previous conditions are not met
            return true;
        }

        public static void Main(string[] args)
        {
            //creeate DirectoryInfo to show the way to files
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Home\source\repos\Task 2_2t\Task 2_2t");

            //create StreamReader to read ffrom the file text.txt
            StreamReader sr = new StreamReader("input.txt");

            //create StreamWriter to write in the file output.txt
            StreamWriter sw = new StreamWriter("output.txt");

            //create a variable (based on the read string from the file)
            String s = sr.ReadLine();

            //create an array, based on read numbers separated by space
            string[] txt = s.Split();

            //create cycle to check the numbers 
            for (int i = 0; i < txt.Length; i++)
            {
                //convert each number to integer
                int c = int.Parse(txt[i]);

                //condition: if the function returns true
                if (IsPrime(c) == true)
                {
                    //then write this number to the file
                    sw.Write(c + " ");
                }

            }

            //close used files
            sr.Close();
            sw.Close();
        }
    }
}
