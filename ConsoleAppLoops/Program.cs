// See https://aka.ms/new-console-template for more information
Console.WriteLine("How many times you want to print hello world");
int count = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Hello world {i}");
}
Console.WriteLine("Exit");

Console.WriteLine("While loop sample");
int sum = 0;
int num = 0;
while(num!= -1)
{
    Console.Write("Enter the number to be summed (-1 to exit):");
    num = Convert.ToInt32(Console.ReadLine());
    if(num !=-1 )
    {
        sum += num;
    }  
}
Console.WriteLine($"Sum of the numbers is : {sum}");
Console.WriteLine("Exited loop");

Console.WriteLine("Do while sample");
sum = 0;
num = 0;
do
{
    Console.Write("Enter the number to be summed (-1 to exit):");
    num = Convert.ToInt32(Console.ReadLine());
    if (num != -1)
    {
        sum += num;
    }
}while(num!= -1);
Console.WriteLine($"Sum is {sum}");