namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("This programm making 4 operations with arrays: \n" +
                    "1 step - create and display array\n" +
                    "2 step - looking for positive and negative numbers\n" +
                    "3 step - sorts the array that even numbers appear on even rows and odd numbers appear on odd rows\n" +
                    "4 step - counting how many times using one number\n\n" +
                    "Press 1 for begining or any number to close:)");

                var choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    int[,] array = CreateArray();
                    if (array != null)
                    {
                        CountPositiveNegative(array);
                        SortArray(array);
                        CountNumbersInArray(array);
                    }
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
        private static int[,] CreateArray()
        {
            Random random = new Random();

            Console.WriteLine("Lets create the Array!");

            Console.Write("Enter the number of columns(range 1-6): ");
            int columns = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of rows(range 1-6): ");
            int rows = int.Parse(Console.ReadLine());

            int[,] array = new int[rows, columns];

            if (columns >= 1 && columns <= 6 && rows >= 1 && rows <= 6)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        array[i, j] = random.Next(-9, 10);
                        Console.Write($"{array[i, j]}\t");
                    }
                    Console.WriteLine();
                }
                return array;
            }
            else
            {
                Console.WriteLine("Error: The number of columns and rows must be in the range of 1 to 6.");
                return null;
            }
        }
        private static void CountPositiveNegative(int[,] array)
        {
            Console.WriteLine("\nI trying to counting how many positive and negative numbers...");
            int positiveCount = 0;
            int negativeCount = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] >= 0)
                    {
                        positiveCount++;
                    }
                    else
                    {
                        negativeCount++;
                    }
                }
            }
            Console.WriteLine("In this array:");
            Console.WriteLine($"Positive numbers: {positiveCount}");
            Console.WriteLine($"Negative numbers: {negativeCount}\n");
        }


        //Не получилось заменить числа в массиве на пустоту, поэтому заменил на 111 в нечетных строках и 222 в четных
        private static void SortArray(int[,] array)
        {
            Console.WriteLine("\nNow let's sort the array by even and odd numbers: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i % 2 == 0)
                    {
                        if (array[i, j] % 2 != 0)
                        {
                            Console.Write($"{array[i, j]}\t");
                        }
                        else
                        {
                            array[i, j] = 111;
                            Console.Write($"{array[i, j]}\t");
                        }
                    }
                    else
                    {
                        if (array[i, j] % 2 == 0)
                        {
                            Console.Write($"{array[i, j]}\t");
                        }
                        else
                        {
                            array[i, j] = 222;
                            Console.Write($"{array[i, j]}\t");
                        }
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n");
        }

        private static void CountNumbersInArray(int[,] array)
        {
            Console.WriteLine("Array statistics: ");
            Dictionary<int, int> numberCounts = new Dictionary<int, int>();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    bool isContainNumber = numberCounts.ContainsKey(array[i, j]);

                    if (isContainNumber == false)
                    {
                        numberCounts.Add(array[i, j], 0);
                        for (int k = 0; k < array.GetLength(0); k++)
                        {
                            for (int l = 0; l < array.GetLength(1); l++)
                            {
                                if (array[i, j] == array[k, l])
                                {
                                    numberCounts[array[i, j]]++;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
            foreach (var item in numberCounts)
            {
                Console.WriteLine($"Number {item.Key} appear {item.Value} times");
            }
            Console.WriteLine("\n\n");
        }

    }
}
