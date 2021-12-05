using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"test.txt";
            double sum = 0;
            FileStream fileStream = null;

            if (!File.Exists(filePath))
                fileStream = File.Create(filePath);
            else
                fileStream = File.Open(filePath, FileMode.Create);

            StreamWriter output = new StreamWriter(fileStream);

            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(0,10);
                output.WriteLine(random.Next());
            }
            output.Close();

            string[] lines = File.ReadAllLines(filePath);
            foreach (string s in lines)
            {
                sum = sum + Convert.ToDouble(s);
            }

            Console.WriteLine("Сумма = " + sum);
            Console.ReadKey();
        }
    }
}
