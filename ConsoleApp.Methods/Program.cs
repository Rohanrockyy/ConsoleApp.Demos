// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to methods");

//Void methods completes a task without returning a value

void PrintName()
{
    Console.WriteLine("Rocky"); 
}
//Value returning methods
int GetFiveYearsBack()
{
    int year= DateTime.Now.AddYears(-5).Year;
    return year;
}

//Methods with parameters
void PrintNameWithParameters(string name)
{
    Console.WriteLine("Your name is : " + name);
}
int GetYearDiffParameters(int year)
{
    int yearDiff = DateTime.Now.Year - year;
    return yearDiff;
}

//Methods with optional parameters - it has default value
int GetFutureOrPast(int years=0)
{
    int ResultYear = DateTime.Now.AddYears(years).Year;
    return ResultYear;
}

//Methods with nullable parameters
void NullableParameters(string? name, int? count)
{
    /*if(string.IsNullOrEmpty(name))  //standard way
    {
        name = "Default ";
    }
    if(!count.HasValue)
    {
        count = 1;
    }
    */

    //another way
    name ??= "Default";
    count ??= 1;


    for(int i = 0; i < count; i++)
    {
        Console.WriteLine(name);
    }
}


//Function call

PrintName();  // call the function to print the value
int FiveyearsAgo = GetFiveYearsBack();
Console.WriteLine("Five years ago was " + FiveyearsAgo);

Console.WriteLine("Enter the name");
string name = Console.ReadLine();
PrintNameWithParameters(name);

Console.WriteLine("Enter the year");
int year = Convert.ToInt32(Console.ReadLine());
int YearsAgo = GetYearDiffParameters(year);
Console.WriteLine("The Year Difference is : " +  YearsAgo);

Console.WriteLine("Enter the no of year");
int year = Convert.ToInt32(Console.ReadLine());   

int res = GetFutureOrPast();
Console.WriteLine("The year is " +  res);

int res1 = GetFutureOrPast(year);
Console.WriteLine("The year is " + res1);

NullableParameters(null, null);
NullableParameters("Modi", 3);