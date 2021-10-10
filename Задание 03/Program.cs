using System;

namespace Задание_03
{
    class Program
    {
        //3.Дана строка S. Из строки требуется удалить текст,
        //заключенный в фигурные скобки. В строке может быть несколько фрагментов,
        //заключённых в фигурные скобки. Возможно использование вложенных фигурных скобок,
        //необходимо, чтобы программа это учитывала.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для редактирования:");
            string originalString = Console.ReadLine();

            if (originalString == "") { Console.WriteLine("Пустая строка"); }

            string resultStrig = "";

            byte q = 0; //флаг признака закрытости скобок

            for (byte i = 0; i < originalString.Length; i++)
            {
                if (originalString[i] == '{') { q++; } //Открываем скобку

                if (q == 0) { resultStrig += originalString[i]; }
                //Пока скобка закрыта, заносим символы в результирующую строку

                if (originalString[i] == '}') { q--; } //Закрываем скобку
            }

            Console.WriteLine();
            Console.WriteLine("Результат преобразование текста:");
            Console.WriteLine(resultStrig);
            Console.ReadKey();

        }
    }
}
