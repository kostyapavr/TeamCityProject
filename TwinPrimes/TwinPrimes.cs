namespace TwinPrimes
{
    internal class TwinPrimes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Парные простые числа");
            int n = 1;
            Console.Write("Введите число: ");
            n = int.Parse(Console.ReadLine());

            int pairCnt = 1;
            int i = 1;
            while (pairCnt <= n)
            {
                int num1 = 6 * i - 1;
                int num2 = 6 * i + 1;
                if (isPrime(num1) && isPrime(num2))
                {
                    Console.WriteLine($"Пара {pairCnt}: ({num1}, {num2})");
                    pairCnt++;
                }
                i++;
            }
        }

        static bool isPrime(int n)
        {
            int p = (int)Math.Sqrt(n);
            for (int i = 2; i <= p; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
