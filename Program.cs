namespace MemoryLab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--- Эксперимент 1: Value vs Reference ---");
            int value = 1;
            int[] array = { 1, 2, 3 };

            Console.WriteLine("Перед методами Value Type - " + value);
            Console.WriteLine("Перед методами Reference Type - " + array[0] + "\n");

            MemoryExperiments.MutateValue(value);
            MemoryExperiments.MutateReference(array);

            Console.WriteLine("После методов Value Type - " + value);
            Console.WriteLine("После методов Reference Type - " + array[0]);

            Console.WriteLine("----------------------------------------\n");



            Console.WriteLine("\n--- Эксперимент 2: Цена Боксинга ---");
            PerformanceTests.RunBoxingTest();
            Console.WriteLine("----------------------------------------");
        }
    }
}
