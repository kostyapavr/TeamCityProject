namespace TwinPrimes
{
    public class TwinPrimes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Парные простые числа");
            int n = 1;
            Console.Write("Введите число: ");
            bool suc = int.TryParse(Console.ReadLine(), out n);
            if (!suc)
            {
                Console.WriteLine("Ошибка чтения ввода!");
                return;
            }

            int num = 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Пара {i+1}: {getNextPair(ref num)}");
            }
        }

        public static bool isPrime(int n)
        {
            if (n <= 1) return false;
            int p = (int)Math.Sqrt(n);
            for (int i = 2; i <= p; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static string getNextPair(ref int i)
        {
            int num1 = 6 * i - 1;
            int num2 = 6 * i + 1;
            while (!(isPrime(num1) && isPrime(num2)))
            {
                i++;
                num1 = 6 * i - 1;
                num2 = 6 * i + 1;
            }
            i++;
            return $"({num1}, {num2})";
        }
    }
}
