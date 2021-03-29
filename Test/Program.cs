using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        public static void Stre(string s)//метод для подсчета повторений числа в строке
        {
            int count = 0;
            char ch = ' ';
 
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (Char.IsDigit(s[i]))//проверка на то что симлов в строке число
                {
                    if (ch != s[i] && ch != s[i + 1])
                    {
                        ch = s[i];//сохранение этого символа
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
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            string str = "t5qr33d56q3";
            Console.WriteLine("input:{0}", str);
            Console.WriteLine("output:");
            Stre(str);

            Console.WriteLine();
            str = ";f2*14'2444";
            Console.WriteLine("input:{0}", str);
            Console.WriteLine("output:");
            Stre(str);

            Console.WriteLine("Задание 2");
            int[] mas = { 1, 2, 3};
            int count = 8;
            Cycler cycler = new Cycler(mas);      
            Console.WriteLine("output:");
            cycler.Next(count);
            Console.ReadKey();
        }
    }
}
