using System.Globalization;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = CreateList();
            PrintList(numbers);
            while (true)
            {
                OperationsWithList(numbers);
            }
        }

        static List<int> CreateList()
        {
            List<int> numbers = new List<int>();
            Random rand = new Random();

            Console.Write("Enter the number of random integers to generate: ");
            int initialCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < initialCount; i++)
            {
                int randomNumber = rand.Next(1, 11);
                numbers.Add(randomNumber);
            }
            return numbers;
        }

        static void PrintList(List<int> numbers)
        {
            Console.WriteLine("Current List: ");
            foreach (var number in numbers)
            {
                Console.Write($"{number}\t");
            }
        }

        static void OperationsWithList(List<int> numbers)
        {
            Console.WriteLine("\n\nChoose the operation you wanna do: \n" +
                "1 - add random number to list;\n" +
                "2 - delete number from list;\n" +
                "3 - modify numbers in list;\n" +
                "4 - modify list to HashSet\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddNumberToList(numbers);
                    break;
                case 2:
                    DeleteNumberFromList(numbers);
                    break;
                case 3:
                    ModifyNumbersInList(numbers);
                    break;
                case 4:
                    ModifyListToHashSet(numbers);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            static void AddNumberToList(List<int> numbers)
            {
                Random rand = new Random();
                int randomNumber = rand.Next(1, 11);
                numbers.Add(randomNumber);
                Console.WriteLine($"\nAdded number: {randomNumber}\n");
                PrintList(numbers);
            }

            static void DeleteNumberFromList(List<int> numbers)
            {
                Console.Write($"Enter the index (range 0-{numbers.Count} of number you wanna delete: ");
                int indexToDelete = Convert.ToInt32(Console.ReadLine());
                indexToDelete -= 1;
                if (indexToDelete >= 0 && indexToDelete < numbers.Count)
                {
                    Console.WriteLine($"\nDeleted number {numbers[indexToDelete]} at index: {indexToDelete + 1}\n");
                    numbers.RemoveAt(indexToDelete);
                }
                else
                {
                    Console.WriteLine("Invalid index. Please try again.");
                }
            }

            static void ModifyNumbersInList(List<int> numbers)
            {
                Console.WriteLine("Modifying numbers in the list...");
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        numbers[i] *= 2;
                    }
                    else
                    {
                        numbers[i] *= 0;

                    }
                }
                PrintList(numbers);
            }

            static void ModifyListToHashSet(List<int> numbers)
            {
                HashSet<int> hashSetNums = new HashSet<int>();
                Console.WriteLine("Modifyied list to hashset: ");
                hashSetNums.UnionWith(numbers);
                foreach (var number in hashSetNums)
                {
                    Console.Write($"{number}\t");
                }               
            }
        }
    }
}
