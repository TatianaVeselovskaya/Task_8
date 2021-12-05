using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"d:\BIM");

            Console.WriteLine("============Список папок=============");
            foreach (var item in dir.GetDirectories())
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("*****Список подкаталогов и файлов*****");
                foreach (var it in item.GetDirectories())
                { Console.WriteLine(it.Name); }
                foreach (var it in item.GetFiles())
                { Console.WriteLine(it.Name); }
                Console.WriteLine();
            }
            Console.WriteLine("=============Список файлов=============");
            foreach (var item in dir.GetFiles())
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadKey();
        }
    }
}
