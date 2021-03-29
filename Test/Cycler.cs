using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Cycler
    {
        int[] mas1;

        public Cycler(int [] mas)//конструктор для принятия массива
        {
            mas1 = mas;
        }

        public void Next( int count)//метод для выведения значений массива
        {
            int i = 0;

            while (i <= count-1)
            {
                if (mas1.Length <= i)
                {
                    count = count - i;
                    i = 0;
                }
                else
                {
                    Console.Write(mas1[i] + " ");
                    i++;
                }
            }
        }
    }
}
