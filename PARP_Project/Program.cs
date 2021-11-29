using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARP_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var intArray = Enumerable.Range(0, 100000);

            DateTime start = DateTime.Now;
            foreach (var i in intArray)
            {
                Operate(i);
            }

            DateTime end = DateTime.Now;

            Console.WriteLine($"Time duration (no parallel) (in ms): {(end - start).TotalMilliseconds}");


            start = DateTime.Now;
            Parallel.ForEach(intArray, Operate);
            end = DateTime.Now;


            Console.WriteLine($"Time duration (with parallel) (in ms): {(end - start).TotalMilliseconds}");

            Console.ReadLine();
        }


        private static void Operate(int number)
        {
            int result = 0;

            for (int i = 0; i < number; i++)
            {
                result += i;
            }
        }
    }
}
