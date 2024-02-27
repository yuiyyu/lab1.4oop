using System;

namespace lab4oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double>[] arr = new Func<double, double>[3]
            {
                (double x) => Math.Sqrt(Math.Abs(x)),
                (double x) => Math.Pow(x, 3.0),
                (double x) => x + 3.5
            };
            while (true)
            {
                try
                {
                    string[] arr2 = Console.ReadLine().Trim().Split(' ');
                    Console.WriteLine(arr[int.Parse(arr2[0])](double.Parse(arr2[1])));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Помилка");
                }
            }
        }
    }
}
