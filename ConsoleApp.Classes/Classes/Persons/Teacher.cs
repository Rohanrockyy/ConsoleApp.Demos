using ConsoleApp.Classes.Utils;

namespace ConsoleApp.Classes.Classes.Persons;

public class Teacher : Person
{
    public void GetTeacherIdNumber()
    {
        _idNumber = PersonHelper.GenerateIdNumber("TEAC");
       // Console.WriteLine("Id number of the Teacher is " + _idNumber);
    }
}
