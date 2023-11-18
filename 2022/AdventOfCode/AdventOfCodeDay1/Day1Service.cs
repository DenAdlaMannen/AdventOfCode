using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeDay1
{
    public class Day1Service
    {
        public double FindTheStrongestElf()
        {
            double mostCalories = 0;
            double temp = 0;

            var domain = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            StreamReader sr = new StreamReader($"{domain}/ElfCalories.txt");

            string line = sr.ReadLine();

            while (line != null)
            {
                //Console.WriteLine(line);

                if (string.IsNullOrEmpty(line) && temp > mostCalories)
                {
                    mostCalories = temp;
                    temp = 0;
                }


                if(int.TryParse(line, out _))
                temp += Convert.ToDouble(line);

                line = sr.ReadLine();
            }

            sr.Close();

            return mostCalories;
        }
    }
}
