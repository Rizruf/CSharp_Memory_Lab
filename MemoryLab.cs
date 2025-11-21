using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryLab
{
    public static class MemoryExperiments
    {
        public static void MutateValue(int Value)
        {
            int value = 9999;
        }
        public static void MutateReference(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                array[0] = 9999;
            }
        }
    }
}
