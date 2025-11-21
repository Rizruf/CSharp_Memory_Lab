using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryLab
{
    internal class LargeObjectHeapTests
    {
        public static void RunLohSpamTest()
        {
            const int iterations = 10;
            const int objectSize = 100 * 1024; // 100 KB, что > 85KB порога LOH

            Console.WriteLine($"Начальная память: {GC.GetTotalMemory(false) / 1024} KB");

            List<byte[]> largeObjects = new List<byte[]>();
            for (int i = 0; i < iterations; i++)
            {
                byte[] bigArray = new byte[objectSize];
                largeObjects.Add(bigArray);
                // Запрашиваем сборку мусора, чтобы увидеть более "честные" цифры памяти
                GC.Collect();
                Console.WriteLine($"Шаг {i + 1}, добавили 100КБ. Память: {GC.GetTotalMemory(false) / 1024} KB");
            }
        }
    }
}
