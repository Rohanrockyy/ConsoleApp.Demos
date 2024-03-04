// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the sample calculator");

Console.Write("Select from option");
Console.WriteLine("\n 1.Add \n 2.Sub \n 3.Mul \n 4.Div \n 5.Mod");
Console.Write("Enter the option :");
int option = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the second number");
int num2 = Convert.ToInt32(Console.ReadLine());

int value=0;
switch(option)
{
    case 1:
        value = num1 + num2;
        Console.WriteLine($"Addtion of values is {value}");
        break;
    case 2:
        value = num1 - num2;
        Console.WriteLine($"Subtraction of values is {value}");
        break;
    case 3:
        value = num1 * num2;
        Console.WriteLine($"Multiplication of values is {value}");
        break;
    case 4:
        value = num1 / num2;
        Console.WriteLine($"Division of values is {value}");
        break;
    case 5:
        value = num1 % num2;
        Console.WriteLine($"Modulas of values is {value}");
        break;
    default:
        Console.WriteLine("Invalid option");
        break;
}
Console.WriteLine($"Answer for selected option is {value}");
