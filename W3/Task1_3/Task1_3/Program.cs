using System;
using System.IO;

namespace Task1
{
    //create class
    class FarManager
    {
        /* variables :
         cursor - points to where the cursor is at the moment
         sz - size(number), to move the cursor from a given direction
         ok - show or hide hidden files
         path
         */
        public int cursor;
        public string path;
        public int sz;
        public bool ok;

        DirectoryInfo directory = null;
        FileSystemInfo currentFs = null;



        // constructor which obtain path and Write it into original path
        public FarManager(string path)
        {
            this.path = path; // "this" is used to do not confuse pathes
            cursor = 0; // cursor is on the first element
            directory = new DirectoryInfo(path); //Create the Direcotory and send the path
            sz = directory.GetFileSystemInfos().Length; // sixe - all elements in array
            ok = true; // hide the hidden element
        }

        //function for coloring elements/background in console 
        public void Color(FileSystemInfo fs, int index) //индекс - номер(место) элемента списка
        {
            if (cursor == index) // condition: cursor is equal to the index of the array
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                currentFs = fs;
            }
            else if (fs.GetType() == typeof(DirectoryInfo)) // condition: for folders
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else // otherwise if it is a file
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }

        //function: showing hidden elements
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Black; // by default background is black
            Console.Clear();
            directory = new DirectoryInfo(path); //Create the Direcotory and send the path
            FileSystemInfo[] fs = directory.GetFileSystemInfos(); // Get the info about elements and write into array
            for (int i = 0, k = 0; i < fs.Length; i++)
            {
                if (ok == true && fs[i].Name[0] == '.')//if the files is hidden or its name begins from "." 
                {
                    continue;
                }
                Color(fs[i], k); // call the function to paint
                Console.WriteLine(fs[i].Name); // shows name of the element
                k++;
            }
        }
        //function to go up
        public void Up()
        {
            cursor--;
            if (cursor < 0) //if the cursor is equal to less than 0 then it goes to the end of the array(to the last element)
                cursor = sz - 1;
        }
        //function to go down
        public void Down()
        {
            cursor++;
            if (cursor == sz) //if the cursor is on the last element of the array then click down and go to the beginning(to the first element)
                cursor = 0;
        }

        public void CalcSz() //function: to calculate the size of the array without hidden files
        {
            directory = new DirectoryInfo(path); // create the directory and send the path
            FileSystemInfo[] fs = directory.GetFileSystemInfos(); // create an array and write an array of all elements from directory (all element to the created array )
            sz = fs.Length; // size of all elements 
            if (ok == false) // condition for hidden elements
                for (int i = 0; i < fs.Length; i++)
                    if (fs[i].Name[0] == '.')
                        sz--;
        }

        //Main function
        public void Start()
        {
            ConsoleKeyInfo consoleKey = Console.ReadKey(); // press any key to open the folder(to start)
            while (consoleKey.Key != ConsoleKey.Escape) //the window will be open until we click "escape"
            {
                CalcSz(); // function : calculate the size of the array without hidden files
                Show(); // function : show all elemets
                consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.UpArrow) // uparrow - function up
                    Up();
                if (consoleKey.Key == ConsoleKey.DownArrow) //downarrow - function down
                    Down();
                if (consoleKey.Key == ConsoleKey.RightArrow) // rightarrow - show hidden elements
                {
                    ok = true;
                    cursor = 0;
                }
                if (consoleKey.Key == ConsoleKey.LeftArrow) // leftarrow - hide hidden elements
                {
                    cursor = 0;
                    ok = false;
                }
                if (consoleKey.Key == ConsoleKey.Enter) // enter - open the element
                {
                    if (currentFs.GetType() == typeof(DirectoryInfo)) // checking for folder
                    {
                        cursor = 0;
                        path = currentFs.FullName; //open the folder
                    }
                    else
                    {
                        Console.Clear(); // otherwise : open the file
                        StreamReader New = new StreamReader(currentFs.FullName);
                        Console.Write(New.ReadLine());
                        New.Close();
                        Console.ReadKey();
                    }
                }
                if (consoleKey.Key == ConsoleKey.Delete) // delete - Delete elements
                {
                    if (currentFs.GetType() == typeof(DirectoryInfo)) //checking for folder
                    {
                        cursor = 0;
                        Directory.Delete(currentFs.FullName, true); //delete the folder
                    }
                    else
                    {
                        cursor = 0;
                        File.Delete(currentFs.FullName); //otherwise: delete the file
                    }
                }
                if (consoleKey.Key == ConsoleKey.Tab) // tab - rname elements
                {
                    Console.Clear();
                    string name = Console.ReadLine(); // write the new name for the element
                    Console.Clear();
                    string copPath = Path.Combine(currentFs.FullName, name); // create the new path using new name
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                    {
                        Directory.Move(currentFs.FullName, copPath);
                    }
                    else
                    {
                        File.Move(currentFs.FullName, copPath);
                    }

                    if (consoleKey.Key == ConsoleKey.Backspace) // backspase - go back
                    {
                        cursor = 0;
                        path = directory.Parent.FullName;
                    }
                }
            }

        }

        class Program
        {
            static void Main(string[] args)
            {
                string path = "C:/Users/Home/source/repos";
                FarManager farManager = new FarManager(path);
                farManager.Start(); // call  the function start
            }
        }
    }
}
