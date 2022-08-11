// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello,DN programmer!");
Console.WriteLine("Here's simple calculator");
Console.WriteLine("Enjoy!");

Console.WriteLine("Please tell me your first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please tell your secound number");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What kind of operation you want ot make?\n"
    + "add - addition\n"
    + "sub - substraction\n"
    + "mul - multiplication\n"
    + "div - dividing"
    );
String operationType = Console.ReadLine();

switch (operationType) {
    case "add":
        Console.WriteLine($"Your result: {firstNumber} + {secondNumber} = " + (firstNumber + secondNumber));
        break;
    case "sub":
        Console.WriteLine($"Your result: {firstNumber} - {secondNumber} = " + (firstNumber - secondNumber));
        break;
    case "mul":
        Console.WriteLine($"Your result: {firstNumber} * {secondNumber} = " + (firstNumber * secondNumber));
        break;
    case "div":
        try
        {
            Console.WriteLine($"Your result: {firstNumber} / {secondNumber} = " + (firstNumber / secondNumber));
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Whooa, slow down cowboy, did you just tried to divide by 0 ?");
        }
            break;
    default:
        {
            Console.WriteLine("please type correct operation type"); 
            break;
        }
    }

   




