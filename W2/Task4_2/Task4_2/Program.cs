using System;
using System.IO;

namespace Task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //path for 1st file
            string path1 = @"C:\Users\Home\source\repos\Task3_2\text.txt";

            //path for 2nd file (its copy)
            string path2 = @"C:\Users\Home\source\repos\Task4_2\text.txt";

            //create a file in path1
            FileInfo fs = new FileInfo(path1);

            //copy created file to path2
            fs.CopyTo(path2);

            //delete created file in path1
            fs.Delete();
        }
    }
}
