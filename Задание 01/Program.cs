using System;

namespace Задание_01
{
    class Program
    {
        //1.Ввести с клавиатуры предложение.
        //Предложение представляет собой слова, разделенные пробелом.
        //Знаки препинания не используются.
        //Найти самое длинное слово в строке.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите с клавиатуры предложение:");
            string originalString = Console.ReadLine();

            if (originalString == "") { Console.WriteLine("Пустая строка"); }

            string[] stringArray = originalString.Split(' '); //Создаём строковый массив, содержащий слова исходного предложения

            int maxResult = 0; //длина самого длинного слова
            int maxNum = 0; //порядковый номер самого длинного слова
            int i = 0;
            
            //Проводим поиск самого длинного слова
            foreach (string str in stringArray)
            {
                if (str.Length > maxResult)
                { 
                    maxResult = str.Length; 
                    maxNum = i;
                }
                    i++;
            }

            Console.WriteLine();
            Console.WriteLine("Самое длинное солово:");
            Console.WriteLine(stringArray[maxNum]);

        }
    }
}
