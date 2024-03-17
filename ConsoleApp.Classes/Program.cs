// See https://aka.ms/new-console-template for more information
using ConsoleApp.Classes;
using ConsoleApp.Classes.Classes.Persons;
using ConsoleApp.Classes.Classes.Shapes;

Console.WriteLine("Welcome to classes and objects");

//Define a object of type person

Person person; // it will be null by default as we didn't initialize
Person child = new Person(); // initialized new instance that is person
child.LastName = "Kumar yadav";
child.FirstName = "Surya";
child.DoB = new DateOnly(1999,09,09);

//Console.WriteLine($"Full name is {child.FirstName} {child.LastName} ");
child.PersonFullName();
child.PrintInitials();
child.GetAndSetTaxNumber();

//Another method to print TaxNumber
//var taxNumber = child.GetTaxNumber();
//Console.WriteLine($"The Tax Number is {taxNumber}");

//constructor 
var person1 = new Person("Sandy","Maddy",new DateOnly(1990,01,02));
person1.PersonFullName();
person1.PrintInitials();
person1.GetAge();

var person2 = new Person("Sam", "Vitwicky", "1230987");
person2.PersonFullName();
person2.PrintInitials();
person2.GetAndSetTaxNumber();

var person3 = new Person("Autobots", "Decepticons", "");
person3.PersonFullName();
person3.PrintInitials();
person3.GetAndSetTaxNumber();
var personIdNumber = person3.GetIdNumber();
Console.WriteLine(personIdNumber);

var teacher = new Teacher();

teacher.LastName = "Kumar yadav";
teacher.FirstName = "Surya";
teacher.DoB = new DateOnly(1999, 09, 09);

teacher.PersonFullName();
teacher.PrintInitials();
teacher.GetAndSetTaxNumber();
teacher.GetTeacherIdNumber();

var teacherIdNumber = teacher.GetIdNumber();
Console.WriteLine(teacherIdNumber);

Student student = new();   //we can initialize like this also

//Student student = new() { FirstName = string.Empty, LastName = string.Empty };
//If we use public required we must use as above method to initialize

student.LastName = "Kumar yadav";
student.FirstName = "Surya";
student.DoB = new DateOnly(1999, 09, 09);

student.PersonFullName();
student.PrintInitials();
student.GetAndSetTaxNumber();
student.GetStudentIdNumber();

var studentIdNumber = student.GetIdNumber();
Console.WriteLine(studentIdNumber);

//Polygon polygon = new Polygon();  //Compiler error as we cant create instance to abstract class

Rectangle rectangle = new(10, 20);
var RecArea = rectangle.area();
Console.WriteLine("The area of Rectangle is : " +RecArea);
//rectangle.GetShapeName();

Square square = new(10);
var SqArea =  square.area();
Console.WriteLine("The area of Square is : " + SqArea);

Cuboid cuboid = new Cuboid(1,2,3);
var cuboidArea = cuboid.area();
var cuboidPerimeter = cuboid.Perimeter();
var cuboidVolume = cuboid.Volume();

Console.WriteLine($"The cuboid area is {cuboidArea}");
Console.WriteLine($"The cuboid volume is {cuboidVolume}");
Console.WriteLine("The cuboid Perimeter is " + cuboidPerimeter);

Sphere sphere = new Sphere(2);
var sphereCircumference = sphere.Circumference();
var sphereVolume = sphere.Volume();

Console.WriteLine($"The cuboid Circumference is {sphereCircumference}");
Console.WriteLine($"The cuboid volume is {sphereVolume}");