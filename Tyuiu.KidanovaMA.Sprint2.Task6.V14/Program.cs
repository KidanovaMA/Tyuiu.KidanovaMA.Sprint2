using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KidanovaMA.Sprint2.Task6.V14.Lib;

namespace Tyuiu.KidanovaMA.Sprint2.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Киданова Мария Александровна | АСОиУБ 26-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("* Условие: Дано целое число k (1 <= k <= 365). Определить, каким днем     *");
            Console.WriteLine("* недели (понедельником, вторником, …, субботой или воскресеньем)         *");
            Console.WriteLine("* является k-й день не високосного года, в котором 1 января d-й день      *");
            Console.WriteLine("* (если 1 января — понедельник, то d = 1 , если вторник — d = 2 , …,      *");
            Console.WriteLine("* если воскресенье — d = 7).                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите число: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число каким днём было 1 января: ");
            int d = Convert.ToInt32(Console.ReadLine());

            string res = ds.FindDayName(k, d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Этот день был " + res);

            Console.ReadKey();
        }
    }
}