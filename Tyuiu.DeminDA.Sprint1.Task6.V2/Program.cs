using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DeminDA.Sprint1.Task6.V2.Lib;

namespace Tyuiu.DeminDA.Sprint1.Task6.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Введите текст");
            string text = Convert.ToString(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            string res = Convert.ToString(ds.CheckHello(text));

            Console.WriteLine(res);
            Console.ReadLine();
        }
            
    }
}
    

