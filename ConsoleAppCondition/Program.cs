// See https://aka.ms/new-console-template for more information
Console.Write("Enter the student's grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

if(grade <0 || grade >100)
{
    Console.WriteLine("Invalid score");
    Console.WriteLine("Enter correct score");
}
else if (grade == 60 || grade <=64 && grade >=61)
{
    Console.WriteLine("Student scored E grade");
}
else if(grade >= 65 && grade<=69)
{
    Console.WriteLine("Student scored D grade");
}
else if (grade >= 70 && grade<=79)
{
    Console.WriteLine("Student scored C grade");
}
else if (grade >= 80 && grade<=89)
{
    Console.WriteLine("Student scored B grade");
}
else if (grade >= 90 && grade <=100)
{
    Console.WriteLine("Student scored A grade");
}
else
{
    Console.WriteLine("Student scored U grade");
    Console.WriteLine("Re appear for the exams");
}
string passStatus = grade <= 59 ? "Fail" : "Pass";
Console.WriteLine($"Student status is {passStatus}");
Console.WriteLine("Thankyou");

Console.WriteLine("Enter the value");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1:
        Console.WriteLine("Sunday");
        Console.WriteLine("Holiday");
        break;

    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday");
        break;
    case 7:
        Console.WriteLine("Saturday");
        Console.WriteLine("Weekoff");
        break;
    default:
        Console.WriteLine("Invalid day");
        break;
}