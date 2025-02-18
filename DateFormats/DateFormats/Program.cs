using System.Globalization;
DateTime d1 = DateTime.Parse("2000-08-15");
DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");

DateTime d3 = DateTime.Parse("15/08/2000");
DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");
DateTime d5 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

Console.WriteLine(d1);
Console.WriteLine(d2);

Console.WriteLine(d3);
Console.WriteLine(d4);
Console.WriteLine(d5);

DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

Console.WriteLine(d);
Console.WriteLine("1) Date: " + d.Date);
Console.WriteLine("2) Day: " + d.Day);
Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
Console.WriteLine("5) Hour: " + d.Hour);
Console.WriteLine("6) Kind: " + d.Kind);
Console.WriteLine("7) Millisecond: " + d.Millisecond);
Console.WriteLine("8) Minute: " + d.Minute);
Console.WriteLine("9) Month: " + d.Month);
Console.WriteLine("10) Second: " + d.Second);
Console.WriteLine("11) Ticks: " + d.Ticks);
Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
Console.WriteLine("13) Year: " + d.Year);
string s1 = d.ToLongDateString();
string s2 = d.ToLongTimeString();
string s3 = d.ToShortDateString();
string s4 = d.ToShortTimeString();
string s5 = d.ToString("yyyy-MM-dd HH:mm:ss");
Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
Console.WriteLine(s4);
Console.WriteLine(s5);

DateTime data1 = new DateTime(2000, 10, 15);
DateTime data2 = new DateTime(2000, 10, 18);

TimeSpan t = data2.Subtract(data1);

Console.WriteLine(t);