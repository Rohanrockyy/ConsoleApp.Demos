// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to string manipulation");

//initialising the regular string
string s1 = "This is string";
string s2 = "Vanakkam";
Console.WriteLine($"{nameof(s1)}:{s1}");
Console.WriteLine($"{nameof(s2)}:{s2}"); 
//initialising  the empty string
string s3 =string.Empty;       //this is efficient option
Console.WriteLine($"{nameof(s3)}:{s3}");
//string s3=""; 

//Declare without initialising (possible null exception)
string s4;
//Console.WriteLine($"{nameof(s4)}:{s4}"); doesn't run as its not initialised

//Initialize to null (Possible null exception)
string? s5= null;
Console.WriteLine($"{nameof(s5)}:{s5}");

//Escape sequence and characters
string s6 = "He said,\"he would join armed forces\" \r\n Next line for sample";
Console.WriteLine($"{nameof(s6)}:{s6}");

//Verbatim string
string s7 = "C:\\Programfiles\\files";
string s8 = @"C:\Programfiles\files";
Console.WriteLine($"{nameof(s7)}:{s7}");
Console.WriteLine($"{nameof(s8)}:{s8}");

//use const string to prevent modification to a string
const string s9 = "This is unchangable string";
Console.WriteLine($"{nameof(s9)}:{s9}");

// s9 = "new string"; cannot do this as it is constant string

//Raw string literals
string rawLiterals = """ "This is cool", he said """;
string rawLiterals1 = """ 
    "This is cool", he said
    the new line and
    the next line\line
    """;
Console.WriteLine($"{nameof(rawLiterals)}:{rawLiterals}");
Console.WriteLine($"{nameof(rawLiterals1)}:{rawLiterals1}");

//review concatenation and interpolation
s1 += s2;
s1 = s1 + s2;
Console.WriteLine($"{nameof(s1)}:{s1}");

string newString1 = $" {s1} {s2} some string ";
string newString2 = s1 + $" {s1} {s2} some string";
string newString3 = string.Format("Some string {0}{1}",s1,s2);
Console.WriteLine($"{nameof(newString1)}:{newString1}");
Console.WriteLine($"{nameof(newString2)}:{newString2}");
Console.WriteLine($"{nameof(newString3)}:{newString3}");
//use any type from the above methods

//string manipulation properties and methods
//null or empty checks

//find the length of the string
Console.WriteLine($"{nameof(s1)} has the length of {s1.Length}");
Console.WriteLine($"{nameof(s2)} has the length of {s1.Length}");

//if(string.IsNullOrEmpty(s5)== false)
if (!string.IsNullOrEmpty(s5))
{
    Console.WriteLine($"{nameof(s5)} has the length of {s5.Length}");
}

//substring
string substring = s6.Substring(2);
Console.WriteLine($"{nameof(substring)} : {substring}");
substring = s6.Substring(2,7);
Console.WriteLine($"{nameof(substring)} : {substring}");

//splitting string   //var datatype used when we dont know the exact value we get
var splitstring = s6.Split(' ');
for(int i = 0; i < splitstring.Length; i++)
{
    Console.WriteLine(splitstring[i]);
}

//replace
string replacement = s1.Replace('s', 'v');
Console.WriteLine($"{nameof(replacement)} : {replacement}");

string replacement1 = s1.Replace("string", "Super");
Console.WriteLine($"{nameof(replacement1)} : {replacement1}");

//convert to string
int value = 1231412444;
string strval=value.ToString();
string sentence1=123445532.ToString();//convert any datatype to string
bool choice = false;
choice.ToString();

//changing format

Console.WriteLine("Your salary is : " + value.ToString("C"));
//Console.WriteLine(nameof(value) + ":" + value.ToString("C"));  another method