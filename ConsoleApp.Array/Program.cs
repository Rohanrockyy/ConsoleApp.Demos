// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the Arrays");

//how many students and grades are to be entered
Console.WriteLine("Please enter the no of students and grades to be entered : ");
int NumOfGrades = Convert.ToInt32(Console.ReadLine());

//Fixed array size
//int[] grades=new int[5]; //for a fixed array that is 5

int[] grades = new int[NumOfGrades];
string[] StudentNames = new string[NumOfGrades];

//Add values to fixed array
/*
grades[0] = 12;
grades[1] = 23;
grades[2] = 45;
grades[3] = 67;
grades[4] = 78;
*/

for(int i=0; i < NumOfGrades; i++)
{
    Console.WriteLine("Enter the Student name : ");
    StudentNames[i] = Console.ReadLine();

    Console.WriteLine("Enter the grade");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

//Print values in fixed array

Console.WriteLine("Grades you have entered : ");
for (int i = 0; i < NumOfGrades; i++)
{
    Console.WriteLine($"{StudentNames[i]} : {grades[i]}");
}

//Variable array
/*
string[] StudentNames1 = {"Army","Navy","Air Force"};

//Add values to variable array

for (int i = 0; i < StudentNames1.Length; i++)
{
    Console.WriteLine("Enter the Name");
    StudentNames1[i] = Console.ReadLine();
}

//Print values in variable array

Console.WriteLine("Names you have entered : ");
for (int i = 0; i < StudentNames1.Length; i++)
{
    Console.WriteLine(StudentNames1[i]);
}
*/