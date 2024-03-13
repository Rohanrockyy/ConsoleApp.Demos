// See https://aka.ms/new-console-template for more information
using System.Globalization;

string firstname = string.Empty;
string lastname = string.Empty;
int age = 0;
DateOnly dob  = new DateOnly();
const int retirement = 60;
decimal salary = 0;
char gender =  char.MinValue;
bool working = true;

//prompt for user inputs

Console.Write("Enter the first name: ");
firstname = Console.ReadLine();

Console.Write("Enter the last name: ");
lastname = Console.ReadLine();

Console.Write("Enter the DOB (dd/mm/yyyy) : ");
dob = DateOnly.ParseExact(Console.ReadLine(),"dd/MM/yyyy", CultureInfo.InvariantCulture);
age = DateTime.Now.Year - dob.Year;
Console.WriteLine("Age is " + age);

Console.Write("Enter the salary: ");
salary = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working (True or False): ");
working = Convert.ToBoolean(Console.ReadLine());

//process the inputs

int remaining = retirement - age; 
var estimatedRetirementdate = DateTime.Now.AddYears(remaining);
Console.WriteLine($"User name : { firstname} { lastname}");
Console.WriteLine("User age : " + age);
Console.WriteLine("remaining years :" + remaining);
Console.WriteLine("User salary : " + salary.ToString("C"));
Console.WriteLine("User gender : " + gender);
Console.WriteLine("User working status : " + working);
Console.WriteLine("Retirement date is :" + estimatedRetirementdate.Year);