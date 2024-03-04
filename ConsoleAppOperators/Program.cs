// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.Write("Enter the first number: ");
Decimal num1=Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter the second number: ");
Decimal num2 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine();

//arithmetic

Console.WriteLine("***********Math Operators**********");
Console.WriteLine();
Decimal sum = num1+num2;
Console.WriteLine("The sum is "+sum);

Decimal product = num1 * num2;
Console.WriteLine("The product is "+product);

Decimal div=num1 / num2;
Console.WriteLine("The Division is " + div);

Decimal sub=num1 - num2;
Console.WriteLine("The subtraction is "+sub);

Decimal mod=num1 % num2;
Console.WriteLine("The Modulas is "+mod);
Console.WriteLine();
//logic operators

var isGreaterthan = num1 > num2;
var  isLessthan = num1 < num2;
var isEqualto  = num1 == num2;
var isGreaterOrEqualTo =    num1 >= num2;
var isLesserOrEqualTo = num1 <= num2;
var isNotEqual =  num1 != num2;

Console.WriteLine();
Console.WriteLine("***********Logic Operators**********");
Console.WriteLine();
Console.WriteLine($"Is greaterthan value : {isGreaterthan}" );
Console.WriteLine($"Is Lesserthan value : {isLessthan}");
Console.WriteLine($"Is Equal to value : {isEqualto}");
Console.WriteLine($"Is greaterthan or Equal to value : {isGreaterOrEqualTo}");
Console.WriteLine($"Is Lesserthan or equal to value : {isLesserOrEqualTo}");
Console.WriteLine($"Is Not equal to value : {isNotEqual}");
Console.WriteLine();

//Assigning operators

Console.WriteLine("Enter the random value for assigning operators");
int random = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("***********Assigning Operators**********");
Console.WriteLine();
num1 += random;
Console.WriteLine($"The num1 increased by random is {num1}");
num1 -= random;
Console.WriteLine($"The num1 decreased by random is {num1}");
num1 *= random;
Console.WriteLine($"The num1 Multiplied by random is {num1}");
num1 /= random;
Console.WriteLine($"The num1 Divided by random is {num1}");
num1 %= random;
Console.WriteLine($"The num1 modulus by random is {num1}");
Console.WriteLine();