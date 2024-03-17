// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Xml.Serialization;

string firstname = string.Empty;
string lastname = string.Empty;
int age = 0;
DateOnly dob  = new DateOnly();
int retirement = 60;
decimal salary = 0;
char gender =  char.MinValue;
bool working = true;
char option = char.MinValue;

List<Person>persons = new List<Person>();

while(option!= 'E')
{
    //prompt for user inputs

    Console.Write("Enter the first name: ");
    firstname = Console.ReadLine();

    Console.Write("Enter the last name: ");
    lastname = Console.ReadLine();

    Console.Write("Enter the DOB (dd/mm/yyyy) : ");
    dob = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
    age = DateTime.Now.Year - dob.Year;
    Console.WriteLine("Age is " + age);

    Console.Write("Enter the salary: ");
    salary = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter your gender (M or F): ");
    gender = Convert.ToChar(Console.ReadLine());

    Console.Write("Are you working (True or False): ");
    working = Convert.ToBoolean(Console.ReadLine());

    Person person = new(dob)
    {
        FirstName = firstname,
        LastName = lastname,
        Gender = gender,
        Salary = salary,
        IsWorking = working,
        DoB = dob
    };

    persons.Add(person);

    Console.WriteLine("C - Continue || E - Exit");
    option = Convert.ToChar(Console.ReadLine());
}

foreach(Person person in persons)
{
    Console.WriteLine();
    Console.WriteLine($"User name : {person.ToString()}");
    Console.WriteLine("User age : " + person.GetAge());
    Console.WriteLine("remaining years :" + person.GetRemainingWorkYears());
    Console.WriteLine("User salary : " + person.Salary.ToString("C"));
    Console.WriteLine("User gender : " + person.Gender);
    Console.WriteLine("User working status : " + person.IsWorking);
    Console.WriteLine("Retirement date is :" + person.EstimatedRetirementDate());
}