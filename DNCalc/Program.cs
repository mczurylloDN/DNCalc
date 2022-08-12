// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello,DN programmer!");
Console.WriteLine("Here's simple calculator");
Console.WriteLine("Enjoy!");
//todo prevention vs entering strings
Console.WriteLine("Please tell me your first number");
double firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please tell your secound number");
double secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What kind of operation you want ot make?\n"
    + "add - addition\n"
    + "sub - substraction\n"
    + "mul - multiplication\n"
    + "div - dividing"
    );
//todo make external functions or classes to enable recursion
//this will make it easier to extend program for deal with more numbers
try
{
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
    }
catch (NullReferenceException)
{
    Console.WriteLine("but, Hey ! You have to write something.");
}






