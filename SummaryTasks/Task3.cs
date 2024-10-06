using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummaryTasks
{
    internal class Task3
    {
        //Простые числа из диапазона
        public static int[] Func(int min, int max)
        {
            List<int> result = new List<int>();
            bool isValid = false;

            for(int num = min; num < max; num++)
            {
                isValid = true;
                for(int i = 2; i < num; i++)
                {
                    if(num % i == 0) isValid = false; break;// Проверка на другие делители
                }
                if(isValid) result.Add(num);
            }

            return result.ToArray();
        }
    }
}
