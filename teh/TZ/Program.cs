using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TZ
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int count1 = 0;

            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            string strUpper = str.ToUpper();

            Console.Write("Символ: ");
            string symbol = Console.ReadLine();//ввод символа
            string symbolUpper = symbol.ToUpper();//преобразование символа в заглавную букву

            char symbChar = Convert.ToChar(symbolUpper);//перевод символа в тип char

            char[] ar = strUpper.ToCharArray();//перевод строки(которая уже преобразована в большие буквы) в массив, где каждый символ строки - элемент массива с типом char
            SearchSymb(ref count, ref count1, symbChar, ar);
            Console.WriteLine("Слов, начинающихся с буквы " + symbolUpper + ": " + count);//вывод результата
            Console.WriteLine("Всего слов в строке: " + count1);
            Console.ReadKey();
        }

        private static void SearchSymb(ref int count, ref int count1, char symbChar, char[] ar)
        {
            if (ar[0] == symbChar)//если первый символ соответвует введенному нами символу, то к общему счётчику прибавляется 1
            {
                count++;
            }
            for (int i = 1; i < ar.Length; i++)//далее уже начиная со второго символа строки(т.е. 1 в программировании) идем по каждому элементу массива
            {
                if ((ar[i] == symbChar) && ar[i - 1] == ' ')//если элемент массива соответвует нашей букве, и при этом перед ним стоит пробел, значит это отдельное слово, значит к счётчику прибавляется 1
                {
                    count++;
                }
                if (ar[i] == ' ')
                {
                    count1++;
                }
            }
            count1++;
        }
    }
}
