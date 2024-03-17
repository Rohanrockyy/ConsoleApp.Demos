// See https://aka.ms/new-console-template for more information

//Define a class
using System.Security.Cryptography;

namespace ConsoleApp.Classes.Classes.Persons;

//public sealed class person //is used to prevent inherit the class 

public partial class Person   //partial class used to access constructor of a class within a folder and class cannot do it
{
    public Person()       //constructors
    {

    }
    
    public Person(string firstname,string lastname,string taxnumber) //constructors
    {
        FirstName = firstname;
        LastName = lastname;
        _taxNumber = taxnumber;
    }
    //DateMembers or properties of the class

    //public required string FirstName {get;set;}  //must assign value after creating object
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DoB { get; set; }

    //field member (i.e is private)
    private string _taxNumber;
    protected string _idNumber = "N/A";
    //private readonly string _taxNumber; //as it gives access only to read except in constructor

    public void PersonFullName()   //function or methods
    { 
        var type = GetType().Name; //It prints the type name. In this case its person, so it prints person in {type}
        Console.WriteLine($"{type} Name is {FirstName} {LastName}");
    }

    public void PrintInitials()
    {
        var FirstInitial = FirstName[0];
        var LastInitial = LastName[0];
        Console.WriteLine($"The initial is {FirstInitial} {LastInitial}");
    }

    public string GetAndSetTaxNumber()
    {
        if(string.IsNullOrEmpty(_taxNumber))
        {
            _taxNumber = RandomNumberGenerator.GetInt32(000000, 999999).ToString();
            Console.WriteLine("Tax number is "+  _taxNumber);
            return _taxNumber;
        }
        else
        {
            Console.WriteLine("Tax number already exists - " +  _taxNumber + " for " + FirstName + " " + LastName);
            return _taxNumber;
        }
        
    }

    /*public string GetTaxNumber()
    {
        return _taxNumber;
    }
    */

    public string GetIdNumber()
    {
        return _idNumber;
    }

    protected string RandomGenerator()
    {
        return RandomNumberGenerator.GetInt32(000000, 999999).ToString();
    }
}