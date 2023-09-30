using System;
using System.Threading;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 250; i++)
        {
            Thread.Sleep(20);
        }

        int contador = 0;

        while (contador <= 1000)
        {
            Random random = new Random();
            int a = random.Next(0, 10);
            int b = random.Next(0, 10);
            int c = random.Next(0, 10);
            int d = random.Next(0, 10);
            int e = random.Next(0, 10);
            int f = random.Next(0, 10);
            int g = random.Next(0, 10);
            int h = random.Next(0, 10);
            int i = random.Next(0, 10);
            int j = random.Next(0, 10);
            int k = random.Next(0, 10);
            int l = random.Next(0, 10);
            int m = random.Next(0, 10);
            int n = random.Next(0, 10);
            int o = random.Next(0, 10);
            int p = random.Next(0, 10);

            Console.WriteLine($"{a} {b} {c} {d}  {e} {f} {g} {h}  {i} {j} {k} {l}  {m} {n} {o} {p}");

            Thread.Sleep(50);

            contador++;
        }
    }
}
