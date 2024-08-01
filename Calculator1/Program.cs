class Program
{
    static void Main()
    {
        decimal num1 = GetNumberFromUser("Enter the first number:");
        decimal num2 = GetNumberFromUser("Enter the second number:");

        decimal sum = CalculateSum(num1, num2);

        Console.WriteLine($"The result is {sum:F2}");
    }

    static decimal GetNumberFromUser(string prompt)
    {
        decimal number;
        while (true) {
            Console.WriteLine(prompt);
            string input = Console.ReadLine() ?? "";
            if (input != null && decimal.TryParse(input, out number))
            {
                break;
            }
            else 
            {
                Console.WriteLine("Invalid input, please enter a valid number");
            }
        }
        return number;
    }

    static decimal CalculateSum(decimal num1, decimal num2)
    {
        return num1 + num2;
    }
}