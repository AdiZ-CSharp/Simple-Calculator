Console.WriteLine("This is a calculator. Please enter your first number:");

double num1 = Double.Parse(Console.ReadLine());

Console.WriteLine("\nPlease enter your operation. The options are as follows:\n\nAdd:\t+\n\nSubtract:\t-\n\nMultiply:\t*\n\nDivide:\t/\n\nMultiply to the Power of:\tP");

string operation = Console.ReadLine();

Console.WriteLine("\nPlease enter your second number:");

double num2 = Double.Parse(Console.ReadLine());

double answer;

switch (operation.ToLower())
{
    case "+":
        answer = num1 + num2;
        break;
    case "-":
        answer = num1 - num2;
        break;
    case "*":
        answer = num1 * num2;
        break;
    case "/":
        answer = num1 / num2;
        break;
    case "p":
        answer = Math.Pow(num1, num2);
        break;
    default:
        answer = 0;
        Console.WriteLine("\nSorry, your input wasn't recognised. Please press any key to try again.");
        Console.ReadKey();
        Environment.Exit(0);
        break;
}

Console.WriteLine("\nThe answer to your calculation is: " + answer);


// Wait before ending program
Console.ReadKey();