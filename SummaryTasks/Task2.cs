using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummaryTasks
{
    internal class Task2
    {
        //Общие делители чисел
        public static int[] Func(int[] arr)
        {
            //Берем самое маленькое число из массива до которого будем проверять делители
            int minValue = arr.Min();
            List<int> dividerList = new List<int>();
            bool isValid = false;

            for (int divider = 1; divider <= minValue; divider++)
            {
                isValid = true;
                foreach (int item in arr)
                {
                    //Если хоть одно число делится с остатком, прерываем цикл с данным делителем
                    if (item % divider != 0) isValid = false; break;
                }
                if(isValid) dividerList.Add(divider);
            }

            return dividerList.ToArray();
        }
    }
}
