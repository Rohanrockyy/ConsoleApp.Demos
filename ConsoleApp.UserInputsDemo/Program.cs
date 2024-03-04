// See https://aka.ms/new-console-template for more information
string firstname = string.Empty;
string lastname = string.Empty;
int age = 0;
int retirement = 60;
decimal salary = 0;
char gender =  char.MinValue;
bool working = true;

//prompt for user inputs

Console.Write("Enter the first name: ");
firstname = Console.ReadLine();

Console.Write("Enter the last name: ");
lastname = Console.ReadLine();

Console.Write("Enter the age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the salary: ");
salary = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working (True or False): ");
working = Convert.ToBoolean(Console.ReadLine());

//process the inputs

int remaining = retirement - age; 
Console.WriteLine($"User name : { firstname} { lastname}");
Console.WriteLine("User age : " + age);
Console.WriteLine("remaining years :" + remaining);
Console.WriteLine("User salary : " + salary);
Console.WriteLine("User gender : " + gender);
Console.WriteLine("User working status : " + working);