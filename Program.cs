namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\nChoose the programm: " +
                    "\n1 - Print numbers; " +
                    "\n2 - Print sequence" +
                    "\n3 - Print Fibonacci sequence; " +
                    "\nE/e - Exit\n");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        PrintNumbers();
                        break;
                    case "2":
                        PrintSequenceOfNumbers();
                        break;
                    case "3":
                        PrintFibonacci();
                        break;
                    case "E":
                    case "e":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void PrintNumbers()
        {
            Console.Write("\n\nWrite the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 1)
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = 1; i >= number; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void PrintSequenceOfNumbers()
        {
            Console.Write("\n\nWrite the first number of sequence: ");
            int seqNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the amount of numbers in the sequence: ");
            int seqLength = Convert.ToInt32(Console.ReadLine());
            List<int> sequence = new List<int>();
            int current = seqNumber;
            for (int i = 0; i < seqLength; i++)
            {
                sequence.Add(current);
                Console.WriteLine(sequence[i]);
                current += seqNumber;
            }
        }

        static void PrintFibonacci()
        {
            Console.Write("\n\nWrite the first number of Fibonacci's sequence: ");
            int fiboFirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nWrite the amount of Fibonacci numbers to print: ");
            int fiboLength = Convert.ToInt32(Console.ReadLine());
            List<int> fibo = new List<int> { fiboFirstNumber, fiboFirstNumber };
            Console.WriteLine(fibo[0]);
            Console.WriteLine(fibo[1]);
            for (int i = 2; i < fiboLength; i++)
            {
                int fiboNextNum = fibo[i - 1] + fibo[i - 2];
                fibo.Add(fiboNextNum);
                Console.WriteLine(fibo[i]);
            }
        }
    }
}
