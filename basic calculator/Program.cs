

// TODO: Implement the calculator logic here

//Prompt user to enter first number
Console.WriteLine("Enter the first number");
double num1 = Convert.ToDouble(Console.ReadLine());

//Prompt user to enter second number
Console.WriteLine("Enter the second number");
double num2 = Convert.ToDouble(Console.ReadLine());

//Promot user to enter arithmetic operator
Console.WriteLine("Choose an operation: +, -, *, /");
string arithmetic_op = Console.ReadLine();

if (arithmetic_op == "+")
{
    Console.WriteLine($"Result {num1 + num2}");
}
else if (arithmetic_op == "-")
{
    Console.WriteLine($"Result {num1 - num2}");
}
else if (arithmetic_op == "/")
{
    if (num2 != 0)
    {
        Console.WriteLine($"Result {num1 / num2}");
    }
    else
    {
        Console.WriteLine("Error: Division by zero is not allowed.");
    }
}
else
{
    Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
}


Console.ReadKey();