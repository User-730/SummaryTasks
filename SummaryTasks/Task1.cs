using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummaryTasks
{
    internal class Task1
    {
        //Склонение слова компьютер
        public static string Func(int num)
        {
            string strNum = Convert.ToString(num);
            char lastNum = strNum[strNum.Length - 1];
            string word = "Компьютеров";

            if (lastNum == '1') word = "Компьютер";
            else if (lastNum == '2' || lastNum == '3' || lastNum == '4') word = "Компьютера";

            return strNum + word;
        }
    }
}
