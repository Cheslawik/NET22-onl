namespace lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            int num1 = 5;
            int num2 = 8;
            int simpleResult;
            double num3 = 10.0;
            double complResult;
            bool boolResult;

            simpleResult = num1 + num2;
            Console.WriteLine(simpleResult);

            num1 += num2;
            Console.WriteLine(num1);

            simpleResult = num2 - num1;
            Console.WriteLine(simpleResult);

            num2 -= num1;
            Console.WriteLine(num2);

            simpleResult = num1 * num2;
            Console.WriteLine(simpleResult);

            complResult = (double)num1 / num2;
            Console.WriteLine(complResult);

            complResult = num3 % 4.0;
            Console.WriteLine(complResult);

            boolResult = num1 > num2;
            Console.WriteLine(boolResult);

            boolResult = num1 < num2;
            Console.WriteLine(boolResult);

            boolResult = num1 == num2;
            Console.WriteLine(boolResult);

            Console.WriteLine("Operations with ||");
            boolResult = num1 < num2 || num1 > num3;
            Console.WriteLine("Result of example: num1 < num2 || num1 > num3 - " + boolResult);
            boolResult = num1 < num2 || num1 < num3;
            Console.WriteLine("Result of example: num1 > num2 || num1 > num3 - " + boolResult);

            Console.WriteLine("Operations with &&");
            boolResult = num1 < num2 && num1 > num3;
            Console.WriteLine("Result of example: num1 < num2 && num1 > num3 - " + boolResult);
            boolResult = num1 > num2 && num1 > num3;
            Console.WriteLine("Result of example: num1 > num2 && num1 > num3 - " + boolResult);


        }
    }
}
