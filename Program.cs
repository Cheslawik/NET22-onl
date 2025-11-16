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

                if (selection == "Q" || selection == "q")
                {
                    isTrue = false;
                } else if (selection == "6")
                {
                    Console.Write("Enter the number to find the square root: ");
                    double rootNum = Convert.ToDouble(Console.ReadLine());
                   
                        if (rootNum >= 0)
                        {
                            Console.WriteLine($"Result: {Math.Sqrt(rootNum)}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Cannot calculate the square root of a negative number.");
                        }
                    } else
                {
                    Console.Write("Enter the first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    switch (selection)
                    {
                        case "1":
                            Console.WriteLine($"Result: {num1 + num2}");
                            break;
                        case "2":
                            Console.WriteLine($"Result: {num1 - num2}");
                            break;
                        case "3":
                            Console.WriteLine($"Result: {num1 * num2}");
                            break;
                        case "4":
                            if (num2 != 0)
                            {
                                Console.WriteLine($"Result: {num1 / num2}");
                            }
                            else
                            {
                                Console.WriteLine("Error: Division by zero is not allowed.");
                            }
                            break;
                        case "5":
                            Console.WriteLine($"Result: {num1 % num2}");
                            break;                        
                        default:
                            Console.WriteLine("Invalid selection. Please try again.");
                            break;
                    }
                }
            }
        }
    }
}
