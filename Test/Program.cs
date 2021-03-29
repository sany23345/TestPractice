using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        public static void Stre(string s)//метод для подсчета повторений числа
        {
            int count = 0;
            char ch = ' ';

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (Char.IsDigit(s[i]) && ch != s[i + 1])//проверка на то что симлов в строке число
                {
                    ch = s[i];

                    foreach (var x in s)
                    {
                        if (ch == x)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("{0}:{1}", ch, count);
                    count = 0;
                }    
            }
            
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Задание 1");

            string str = "t5qr33d56q3";
            Stre(str);
            Console.WriteLine();
            str = ";f2*14'2444";
            Stre(str);

            Console.ReadKey();
        }
    }
}
