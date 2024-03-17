// See https://aka.ms/new-console-template for more information
public partial class Person
{
    public Person(DateOnly dob)
    {
        age = DateTime.Now.Year-dob.Year;
        DoB= dob;
    }
    //initializing
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateOnly DoB { get; set; }
    public decimal Salary { get; set; }
    public char Gender { get; set; }
    public bool IsWorking { get; set; }
    
    private readonly int age;

    public int GetRemainingWorkYears()
    {
        return Constants.retirement - age;
    }
   
    public DateOnly EstimatedRetirementDate()
    {
        return DateOnly.FromDateTime(DateTime.Now.AddYears(GetRemainingWorkYears()));
    }
    public override string ToString()
    {
        return $" {FirstName} {LastName}";
    }
    public int GetAge()
    {
        return age;
    }
}