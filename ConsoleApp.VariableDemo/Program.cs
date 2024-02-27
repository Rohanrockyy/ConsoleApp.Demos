// See https://aka.ms/new-console-template for more information

//datatypes
// int,string,decimel,float,logical,double

string name = "Rohan";
Console.WriteLine(name);
Console.WriteLine("He is " + name); //string concatenation
Console.WriteLine($"His neighbour is also {name}");//string interpolation
Console.WriteLine("Both {0}'s nickname is Rocky", name);//formatted string

int nu = 10;
Console.WriteLine("the number is :" + nu);

bool isNumber = true;
Console.WriteLine("The number " + nu + " is greater than 9?" + isNumber);