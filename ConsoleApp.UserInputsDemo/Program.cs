// See https://aka.ms/new-console-template for more information
string name = string.Empty;
int age  = 0;
int retirement = 60;

//prompt for user inputs

Console.WriteLine("Enter the name");
name = Console.ReadLine();

Console.WriteLine("Enter the age");
age = Convert.ToInt32(Console.ReadLine());

//process the inputs

int remaining = retirement - age; 
Console.WriteLine("User name :" + name);
Console.WriteLine("User age : " + age);
Console.WriteLine("remaining years :" + remaining);  