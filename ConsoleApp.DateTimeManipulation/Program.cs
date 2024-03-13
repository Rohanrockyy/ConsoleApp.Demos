// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Date Time Manipulation");

//Empty datetime Object
DateTime datetime = new DateTime();

//Create datetime from date and time
var dateofbirth = new DateTime(1999,03,07);
Console.WriteLine("My DOB is : " + dateofbirth);

var dateofbirth1 = new DateTime(1997, 04, 06,04,45,00); //we have initialize kind here to get output
Console.WriteLine("My DOB is : " + dateofbirth1);

Console.WriteLine($"Day of Week : {dateofbirth.DayOfWeek}");
Console.WriteLine($"Day of year : {dateofbirth.DayOfYear}");
Console.WriteLine($"Time of Day : {dateofbirth1.TimeOfDay}");
Console.WriteLine($"Tick : {dateofbirth1.Ticks}");
Console.WriteLine($"Kind : {dateofbirth1.Kind}");

//Create datetime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine($"Timestamp is :{now}");

//Create a datetime value from string
Console.WriteLine("Enter the DOB (DD/MM/YYYY");
string dob = Console.ReadLine();
var userDob = DateTime.Parse(dob);
Console.WriteLine($"Day of Week : {userDob.DayOfWeek}");
Console.WriteLine($"Day of year : {userDob.DayOfYear}");
Console.WriteLine($"Time of Day : {userDob.TimeOfDay}");
Console.WriteLine($"Tick : {userDob.Ticks}");
Console.WriteLine($"Kind : {userDob.Kind}");

//Change datetime format
Console.WriteLine($"Formatted datetime is : {userDob.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Formatted datetime is : {userDob.ToString("ddd/MMM/yyyy")}");
Console.WriteLine($"Formatted datetime is : {userDob:dddd/MM/yyyyy}");

//Add Additional Time
Console.WriteLine("One hour from now is : " + now.AddHours(1));
Console.WriteLine("One Day from now is : " + now.AddDays(1));
Console.WriteLine("One Day from now is : " + now.AddDays(-1));

Console.WriteLine("Date Time Manipulation ended");

//UTC
Console.WriteLine("Date Time offset Manipulation");

var noW = DateTime.Now;
Console.WriteLine($"My time is {noW}");
var utcnow =  DateTime.UtcNow;
Console.WriteLine($"UTC time is " + utcnow);

//Time zone info and date time offset 
var TZ = TimeZoneInfo.Local.GetUtcOffset(utcnow);  //offset used to see the difference
Console.WriteLine("User Time Zone is : " + TZ);

// To store the time zone and DateTime offset
var dto = new DateTimeOffset(now,TZ);
Console.WriteLine("User Time zone with UTC offset " +  dto);
Console.WriteLine("UTC time of action " + dto.UtcDateTime);

//Time zone for specific region
var indiaTZ = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
Console.WriteLine("Indian Time zone is : " +  indiaTZ); 

var indiaDateTime = TimeZoneInfo.ConvertTimeFromUtc(dto.UtcDateTime,indiaTZ);
Console.WriteLine("Action Completed in Indian Time zone is : " + indiaDateTime);

//Date only
var dateOnly = new DateOnly(1999, 09, 08);
var nextDay = dateOnly.AddDays(1);
var nextDecade = dateOnly.AddYears(10); //We can do this for month and years 

Console.WriteLine("The date only is : " +  dateOnly);
Console.WriteLine("The Next date is : " + nextDay);
Console.WriteLine("The Next decade is : " + nextDecade);

var DatefromDateTime = DateOnly.FromDateTime(now);
Console.WriteLine("Date only from Datetime is " +  DatefromDateTime);

Console.WriteLine("Enter the DOB (dd/MMM/yyyy)");
string Dob = Console.ReadLine();
var thedateonly = DateOnly.ParseExact(Dob, "dd/MMM/yyyy", CultureInfo.InvariantCulture);
Console.WriteLine("The Date Only is : " +  thedateonly);

//Time only
var Time = TimeOnly.FromDateTime(now);
Console.WriteLine("Time is : " +  Time);
Console.WriteLine($"Time is : { Time:HH:mm tt}") ; //To show AM or PM

//Date Comparison
var Date1 = new DateTime(1999, 09, 12);
var Date2 = new DateTime(1999, 09, 11);

Console.WriteLine($"Is '{nameof(Date1)}' equal to '{nameof(Date2)}' : {Date1 == Date2} ");
Console.WriteLine($"Is date1 is after than date2? {Date2 < Date1}");