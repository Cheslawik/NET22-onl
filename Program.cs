namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");
            bool isTrue = true;
            while (isTrue)
            {
                Console.WriteLine("\nChoose the operation. Press: \n1 to + \n2 to - \n3 to * \n4 to / \n5 to % \n6 to find root \n'Q' to exit.\n");
                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        Console.Write("Enter the first number: ");
                        double sumNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        double sumNum2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Result: {sumNum1 + sumNum2}");
                        break;
                    case "2":
                        Console.Write("Enter the first number: ");
                        double substrNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        double substrNum2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Result: {substrNum1 - substrNum2}");
                        break;
                    case "3":
                        Console.Write("Enter the first number: ");
                        double multNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        double multNum2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Result: {multNum1 * multNum2}");
                        break;
                    case "4":
                        Console.Write("Enter the first number: ");
                        double divNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        double divNum2 = Convert.ToDouble(Console.ReadLine());
                        if (divNum2 != 0)
                        {
                            Console.WriteLine($"Result: {divNum1 / divNum2}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    case "5":
                        Console.Write("Enter the first number: ");
                        double modNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        double modNum2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Result: {modNum1 % modNum2}");
                        break;
                    case "6":
                        Console.Write("Enter the number to find the square root of number: ");
                        double rootNum = Convert.ToDouble(Console.ReadLine());
                       
                            if (rootNum >= 0)
                            {
                                Console.WriteLine($"Result: {Math.Sqrt(rootNum)}");
                            }
                            else
                            {
                                Console.WriteLine("Error: Cannot calculate the square root of a negative number.");
                            }
                        break;
                    case "Q":
                    case "q":
                        isTrue = false;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        continue;
                }                
            }
        }
    }
}
