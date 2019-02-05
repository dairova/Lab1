using System;

namespace Task2
{
    //create a class Student
    class Student
    {
        //declare variables
        public string name;
        public string id;
        public int year;

        //create a constructor that accepts two values
        public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        //create a function that returns the name 
        public string GetName()
        {
            return name;
        }

        //create a function that returns id
        public string GetId()
        {
            return id;
        }

        //create a function that increases the year of study
        public int GetYear()
        {
            return ++year;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            //read data from the console 
            Student Info = new Student(Console.ReadLine(), Console.ReadLine());

            //create a loop that will be repeated 4 times (4 years of study)
            for (int i = 0; i < 4; i++)
            {
                //call the function that returns the name
                Console.WriteLine(Info.GetName());

                //call the function that returns the id
                Console.WriteLine(Info.GetId());

                //call the function that returns the increased study year
                Console.WriteLine(Info.GetYear());
            }
            Console.ReadKey(true);
        }
    }
}
