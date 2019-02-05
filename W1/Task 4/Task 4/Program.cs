using System;

namespace Ex4
{
	class Program
	{
		static void Main(string[] args)
		{
			string n; //объявляем переменную (для двойного массива)

			n = Console.ReadLine(); //считываем данные(расмер двумерного массива)
			int b = int.Parse(n); //преврашаем строку в целые числа

			int[,] arr = new int[b, b]; //объявляем двумерный массив (bxb)

			for (int i = 1; i <= b; i++) //считываем массив
			{
				for (int j = 1; j <= b; j++) //считываем массив
				{
					if (i >= j) //чтобы вывести треугольник, 
					{
						Console.Write("[*]"); //выводим [*] как элемент массива 
					}
				}
				Console.WriteLine(); //вывод
			}
		}
	}
}
