using System;

namespace Задание_02
{
    class Program
    {
        //2.Ввести с клавиатуры предложение.
        //Предложение представляет собой слова, разделенные пробелом.
        //Знаки препинания не используются. Составить программу,
        //определяющую является ли строка палиндромом
        //без учёта пробелов и регистра
        //(пример палиндрома – «А роза упала на лапу Азора»).
        static void Main(string[] args)
        {
            Console.WriteLine("Введите с клавиатуры предложение не используя знаки припинания и служебные символы:");
            string originalString = Console.ReadLine();

            if (originalString == "") { Console.WriteLine("Пустая строка"); }

            string orglowString = originalString.ToLower();//Создаём копию исходной строки в строчных буквах
            
            string frwString = "";
            
            //Создаём копию строки с исключением пробелов и основных знаков припинания
            for (byte i = 0; i < originalString.Length; i++)
            {
                if (orglowString[i] != '!' &&
                    orglowString[i] != '?' &&
                    orglowString[i] != '.' &&
                    orglowString[i] != ',' &&
                    orglowString[i] != '"' &&
                    orglowString[i] != '-' &&
                    orglowString[i] != ' ')
                
                {frwString += orglowString[i];}
            }
            
            //Создаём копию строки без пробелов и знаков припинания "задом на перёд"
            string bckString = "";
            for (int i = frwString.Length; i > 0; i--)
            {bckString += frwString[i-1];}

            Console.WriteLine();
            //Проверка на признак палиндромии
            if ((String.Compare(frwString, bckString) == 0)) {Console.WriteLine("Данная строка является палиндромом !");}
            else { Console.WriteLine("Данная строка не является палиндромом."); }

            Console.WriteLine("До свидания.");
            Console.ReadKey();
        }
    }
}
