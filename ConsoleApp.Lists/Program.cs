// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Welcome to lists");

//Declare a list

List<int> grades = new List<int>();  //var grades = new List<int>(); another way to declare
List<string> students = new List<string>();
int mark = 0;
string name = string.Empty;
int @continue;
int gradeCount = 0;
//Add values to list
/*
grades.Add(78);
grades.Add(90);
Console.WriteLine(grades[0]);
Console.WriteLine(grades[1]);
*/

do
{
    gradeCount +=1;
    Console.WriteLine("Enter the student name : ");
    name = Console.ReadLine();
    students.Add(name);

    Console.WriteLine("Enter grade Mark : ");
    mark = Convert.ToInt32(Console.ReadLine());
    
    if(mark != -1 )
    {
        grades.Add(mark);
    }
    Console.WriteLine("Do you want to continue (1 = yes, -1 = no) : ");
    @continue = Convert.ToInt32(Console.ReadLine());
}while(@continue == 1);

//Print values in for
Console.WriteLine("Printing the values by for loop");
for (int i = 0; i < gradeCount; i++)
{
    Console.WriteLine($"{students[i]} : {grades[i]}");
}
//Print values in foreach
/*
Console.WriteLine("Printing values by foreach loop");
foreach(int marks in grades)
{
    Console.WriteLine(marks);
}
*/