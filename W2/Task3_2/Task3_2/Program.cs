using System;
using System.IO;

namespace Task3_2
{
    class Program
    {
        // The function that show spaces
        public static void ShowSpace(int level) 
        {
            // Cycle for showing Spaces
            for (int k = 0; k < level; k++) 
            {
                // Output spaces
                Console.Write("    "); 
            }
        }
        // Create a function that will display the name of the files from the specified path
        public static void UsingDirc(DirectoryInfo dir, int level)
        {

            // Cycle for Files
            foreach (FileInfo file in dir.GetFiles()) 
            {

                // Call the function to output the level + 1 (to separate by space givvn files)
                ShowSpace(level + 1);

                // output to the console the name of the file from the given directory
                Console.WriteLine(file.Name); 
            }
            // Cycle for Directories
            foreach (DirectoryInfo direct in dir.GetDirectories()) 
            {
                // Call the function "ShowSpaces" with level + 1 To Separate by space out folders
                ShowSpace(level + 1);

                // Show the name of the Folders
                Console.WriteLine(direct.Name);

                // Recursion (recall the ofigin function with another directory and level)
                UsingDirc(direct, level + 2); 
            }
        }

        static void Main(string[] args)
        {
            // Create DirectoryInfo and show the path
            DirectoryInfo dir = new DirectoryInfo("C:/Users/Home/Desktop/Uni");

            // Show the name Of the folder
            Console.WriteLine(dir.Name);

            //Call the function with dir and 0(the number of spaces)
            UsingDirc(dir, 0);
            Console.ReadKey();
        }
    }
}
