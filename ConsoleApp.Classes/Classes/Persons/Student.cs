using ConsoleApp.Classes.Utils;

namespace ConsoleApp.Classes.Classes.Persons;

public class Student : Person
{
    public void GetStudentIdNumber()
    {
        _idNumber = PersonHelper.GenerateIdNumber("STU");
        //Console.WriteLine("Id number of the Student is ");
    }
}
