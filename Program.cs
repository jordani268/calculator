using System;

namespace Math
{
    public class Calculator
    {
        public static void Addition()
        {
            Console.WriteLine("Addition calculator on!");
            Console.WriteLine("Select your first number."); 
            int add1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select your second number.");
            int add2 = Convert.ToInt32(Console.ReadLine());
            int result = add1 + add2;
            Console.WriteLine("The answer is " + result + ".");
        }
        public static void Subtraction()
        {
            Console.WriteLine("Subtraction calculator on!");
            Console.WriteLine("Select your first number."); 
            int sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select your second number.");
            int sub2 = Convert.ToInt32(Console.ReadLine());
            int result1 = sub1 - sub2;
            Console.WriteLine("The answer is " + result1 + ".");
        }
        public static void Multiplication()
        {
            Console.WriteLine("Multiplication calculator on!");
            Console.WriteLine("Select your first number."); 
            int mult1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select your second number.");
            int mult2 = Convert.ToInt32(Console.ReadLine());
            int result2 = mult1 * mult2;
            Console.WriteLine("The answer is " + result2 + ".");
        }
        public static void Division()
        {
            Console.WriteLine("Division calculator on!");
            Console.WriteLine("Select your first number."); 
            int div1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select your second number.");
            int div2 = Convert.ToInt32(Console.ReadLine());
            if (div2 == 0)
            {
                Console.WriteLine("Can't divide by 0. Answer is 0 anyway");
                Console.ReadLine();
                return;
            }
            else
            {
                int result3 = div1 / div2;
                Console.WriteLine("The answer is " + result3 + ".");
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose what type of calculator you want to use.");
            Console.WriteLine("Adding (1)");
            Console.WriteLine("Subtraction (2)");
            Console.WriteLine("Multiplication (3)");
            Console.WriteLine("Division (4)");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Calculator.Addition();
                    break;
                case 2:
                    Calculator.Subtraction();
                    break;
                case 3:
                    Calculator.Multiplication();
                    break;
                case 4:
                    Calculator.Division();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}