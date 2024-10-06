using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummaryTasks
{
    internal class Task4
    {
        //Таблица умножения
        public static void Func(int max)
        {
            Console.Write("  ");
            for (int row = 1; row <= max; row++)
            {
                Console.Write(row + "  "); //перечисление верхней строки
            }
            Console.WriteLine();

            for (int row = 1; row <= max; row++)
            {
                Console.Write(row); //row номер текущей строки

                for (int column = 1; column <= max; column++)// column номер текущего столбца
                {
                    if (row * column < 10 && column != 1) Console.Write(" "); //Поправки, чтобы выровнять столбцы и строки
                    Console.Write(" " + row * column);
                }
                Console.WriteLine();
            }

            //Если запустите программу в VS Studio она выведет таблицу умножения, можете поменять количество строк в слассе Program
        }
    }
}
