using System;


namespace ConsoleApp5
{
	class Program
	{
		static void Main(string[] args)
		{
			string n; //переменная

			n = Console.ReadLine(); //считываем строку
			int b = int.Parse(n); //преврашаем строку в целые числа

			string[] arr = Console.ReadLine().Split(); //разделяем строку по пробелам(массив)

			for (int i = 0; i < b; i++) //считываем массив
			{
				Console.Write(arr[i] + " " + arr[i] + " "); //выводим элементы массива повторяя 
			}
		}
	}
}
