class Program
{
    static void Main()
    {
        decimal num1 = GetNumberFromUser("Enter the first number:");
        decimal num2 = GetNumberFromUser("Enter the second number:");
        string operation = GetOperation();

        if (operation == "divide" && num2 == 0)
        {
            Console.WriteLine("Error: tried to divide by 0");
        }
        else {
            decimal result = CalculateResult(num1, num2, operation);
            Console.WriteLine($"Result: {result:F2}");
        }
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

    static string GetOperation()
    {
        while (true) {
            Console.WriteLine("Choose add, subtract, multiply or divide");
            string input = Console.ReadLine() ?? "";
            input = input.ToLower();
            if (input == "add" || input == "subtract" || input == "multiply" || input == "divide")
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a valid operation");
            }
        }
    }

    static decimal CalculateResult(decimal num1, decimal num2, string operation)
    {
        return operation switch 
        {
            "add" => num1 + num2,
            "substract" => num1 - num2,
            "multiply" => num1 * num2,
            "divide" => num1 / num2,
            _ => 0,
        };
    }
}