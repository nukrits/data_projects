
// თბილისის დროით მიმდინარე თარიღი
/*
DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
Console.WriteLine(DateTime.Now);
*/
//ლონდონის დროით მიმდინარე თარიღი
/*
var BritishZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");

DateTime dt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified);

DateTime DateTimeInBritishLocal = TimeZoneInfo.ConvertTime(dt, TimeZoneInfo.Utc, BritishZone);
Console.WriteLine(DateTimeInBritishLocal);
*/

//ორ თარიღს შორის დღეების დათვლა.
/*
DateTime start = new DateTime(2022, 05, 15);
DateTime end = new DateTime(2023, 06, 15);

TimeSpan difference = end - start; //create TimeSpan object

Console.WriteLine("Difference in days: " + difference.Days); //Extract days, write to Console.
*/



//მითითებული წელი არის თუ არა ნაკიანი

/*
int year = 2024;
        Console.WriteLine("weli = " + year);
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("nakiani!");
        }
        else
        {
            Console.WriteLine("ar aris nakiani!");
        }
*/


//წინა თვის ბოლო რიცხვი.

/*
var today = DateTime.Today;
var month = new DateTime(today.Year, today.Month, 1);
var first = month.AddMonths(-1);
var last = month.AddDays(-1);
Console.WriteLine(last);

*/
//წინა თვის პირველი რიცხვი
/*
var today = DateTime.Today;
var month = new DateTime(today.Year, today.Month, 1);
var first = month.AddMonths(-1);
var last = month.AddDays(-1);
Console.WriteLine(first);
*/

//მიმდინარე კვირის დღე
//რადგან ვიზუალ სტუდიოში ქართული ფონტით ვერ გამოვიტანე ხუთშაბათი, მოცემული კოდით ვბეჭდავ ნოუთპადში.
/*

using System.Globalization;
using System.Text;

var geoCulture = CultureInfo.CreateSpecificCulture("ka-GE");
var weekday = geoCulture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
using (var writer = new StreamWriter(@"C:\Users\hp\Desktop\C#\cc.txt", false, Encoding.UTF8))
{
    writer.WriteLine(weekday);
}
*/
