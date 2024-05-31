namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Please choose the operation: (+, -, *, /)");
                string function = Console.ReadLine();

                if (function == "+")
                {

                    Console.Write("Please write the first number: ");
                    decimal a = (decimal.Parse(Console.ReadLine()));
                    Console.Write("Please write the second number: ");
                    decimal b = decimal.Parse(Console.ReadLine());
                    decimal c = a + b;
                    Console.WriteLine($"The answer is: {c}");
                }
                else if (function == "-")
                {

                    Console.Write("Please write the first number: ");
                    decimal a = (decimal.Parse(Console.ReadLine()));
                    Console.Write("Please write the second number: ");
                    decimal b = decimal.Parse(Console.ReadLine());
                    decimal c = a - b;
                    Console.WriteLine($"The answer is: {c}");
                }
                else if (function == "*")
                {

                    Console.Write("Please write the first number: ");
                    decimal a = (decimal.Parse(Console.ReadLine()));
                    Console.Write("Please write the second number: ");
                    decimal b = decimal.Parse(Console.ReadLine());
                    decimal c = a * b;
                    Console.WriteLine($"The answer is: {c}");
                }
                else if (function == "/")
                {

                    Console.Write("Please write the first number: ");
                    decimal a = (decimal.Parse(Console.ReadLine()));
                    Console.Write("Please write the second number: ");
                    decimal b = decimal.Parse(Console.ReadLine());

                    if (b != 0)
                    {
                        decimal c = a / b;
                        Console.WriteLine($"The answer is: = {c}");
                    }
                    else
                    {
                        Console.WriteLine("The number can't be devided to 0.");
                    };
                }
                else
                {
                    Console.WriteLine("Please write only these symbols (+, -, *, /).");
                };
        }
    }
}
