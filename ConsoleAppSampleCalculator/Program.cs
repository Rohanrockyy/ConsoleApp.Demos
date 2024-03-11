// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Welcome to the sample calculator");
int option = 0;
int num1, num2;
while (option != -1)
{
    try
    {
        Console.Write("Select from option(-1 to exit)");
        Console.WriteLine("\n 1.Add \n 2.Sub \n 3.Mul \n 4.Div \n 5.Mod \n 6.Fibonacci ");
        Console.Write("Enter the option :");
        option = Convert.ToInt32(Console.ReadLine());
        if (option == -1)
        {
            break;
        }
        else if (option >= 1 && option <= 6)
        {
            Console.WriteLine("Enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            int value = 0;
            switch (option)
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
                case 6:
                    for (int i = num1; i <= num2; i++)
                    {
                        value += i;
                    }
                    Console.WriteLine($"Fibonacci value is {value}");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
                    //throw new Exception("Invalid option");   // we can use this method also
            }
          /*Console.WriteLine($"Answer for selected option is {value}");
            Console.WriteLine("Press any to continue");
            Console.ReadLine();
            Console.Clear(); */
        }
        else
        {
            Console.WriteLine("Invalid option");
        }
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero");
        Console.ReadLine();
        Console.Clear();
    }
    catch (Exception error)
    {
        Console.Write(error.Message);
        //throw;
    }
    finally
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadLine();
        Console.Clear();
    }
}
Console.WriteLine("Thanks for using the calculator");
