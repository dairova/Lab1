using System;
using System.IO;

namespace Task_1_2
{
    class Program
    {
        //создаем функцию, которая возвращает true, false после выполнения условия 
        public static bool P(string str)
        {
            //объявляем переменные: начало слово и конец
            int i = 0;
            int j = str.Length - 1;

            //условие: пока i меньше j(пока отсчет дойдет до середины)
            while (i < j)
            {
                //если значение i-того и j-того элемента не равны, возвращать false
                if (str[i] != str[j])
                    return false;
                //увеличиваем значение i и уменьшаем j, чтобы проверить полностью слово
                i++;
                j--;
            }

            //если указанное выше условие не выполняется, возвращаем true
            return true;
        }

        public static void Main(string[] args)
        {
            //создаем DirectoryInfo для того чтобы указать путь к нашему файлу
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Home\source\repos\Task 1_2\Task 1_2");

            //указываем на файл, с которого необходимо считать даннные
            StreamReader sr = new StreamReader("t.txt");

            //создаем пременную, значением которой будут считанные данные из файла
            String s = sr.ReadLine();

            //пишем считанные данные в кансоль
            Console.WriteLine(s);

            //создаем переменную bool и присваеваем ей результат функции P 
            bool a = P(s);

            //если условие выполнено, выводим "YES"
            if (a == true)
            {
                Console.WriteLine("Yes");
            }

            //в противном случае выводим "NO"
            else
            {
                Console.WriteLine("No");
            }

        }
    }
    }
