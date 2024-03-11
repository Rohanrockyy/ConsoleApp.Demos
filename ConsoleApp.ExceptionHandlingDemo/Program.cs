// See https://aka.ms/new-console-template for more information
try
{
    Console.WriteLine("Enter the age: ");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"The age is {age}");

}
catch (Exception)
{
    Console.WriteLine("Incorrect value. Try again");
	//throw;(will display the exception while running
}
finally
{
    Console.WriteLine("Thanks for using");
}
