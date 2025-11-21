using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryLab
{
    internal class PerformanceTests
    {
        public static void RunBoxingTest()
        {
            const int iterations = 10_000_000;

            // Тест старого ArrayList
            Stopwatch sw = Stopwatch.StartNew();
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < iterations; i++)
            {
                arrayList.Add(i); // Боксинг!
            }
            sw.Stop();
            Console.WriteLine($"ArrayList с боксингом: {sw.ElapsedMilliseconds} ms");

            // Тест нового List<int>
            sw.Restart();
            List<int> genericList = new List<int>();
            for (int i = 0; i < iterations; i++)
            {
                genericList.Add(i); // Без боксинга!
            }
            sw.Stop();
            Console.WriteLine($"List<int> без боксинга: {sw.ElapsedMilliseconds} ms");
        }
    }
}
