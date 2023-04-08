using System.Diagnostics;

namespace ParallelTest
{
    internal class Program
    {
        static void F()
        {
            Thread.Sleep(1000);
        }

        static void Main()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            //Parallel.Invoke(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);

            int elementCount = (int)1000;
            double[] elementArray = new double[elementCount];

            Parallel.For(0, elementCount, i => elementArray[i] = i);

            stopwatch.Stop();

            Parallel.ForEach(elementArray, i => Console.WriteLine(i));

            //Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}