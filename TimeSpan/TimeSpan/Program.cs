TimeSpan t1 = new TimeSpan();
TimeSpan t2 = new TimeSpan(900000000L);

TimeSpan t3 = new TimeSpan(2, 11, 21);
TimeSpan t4 = new TimeSpan(1, 2, 11, 21);

TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

Console.WriteLine(t1);
Console.WriteLine(t2);

Console.WriteLine(t3);
Console.WriteLine(t4);

Console.WriteLine(t5);

TimeSpan t6 = TimeSpan.FromDays(1.5);
TimeSpan t7 = TimeSpan.FromHours(1.5);

TimeSpan t8 = TimeSpan.FromMinutes(1.5);
TimeSpan t9 = TimeSpan.FromSeconds(1.5);

TimeSpan t10 = TimeSpan.FromMilliseconds(1);
TimeSpan t11 = TimeSpan.FromTicks(900000000L);

Console.WriteLine(t6);
Console.WriteLine(t7);

Console.WriteLine(t8);
Console.WriteLine(t9);

Console.WriteLine(t10);
Console.WriteLine(t11);
Console.WriteLine("------------");

TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

Console.WriteLine(t);

Console.WriteLine("Days: " + t.Days);
Console.WriteLine("Hours: " + t.Hours);
Console.WriteLine("Minutes: " + t.Minutes);
Console.WriteLine("Milliseconds: " + t.Milliseconds);
Console.WriteLine("Seconds: " + t.Seconds);
Console.WriteLine("Ticks: " + t.Ticks);

Console.WriteLine("TotalDays: " + t.TotalDays);
Console.WriteLine("TotalHours: " + t.TotalHours);
Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

Console.WriteLine("---------");

TimeSpan time1 = new TimeSpan(1, 30, 10);
TimeSpan time2 = new TimeSpan(0, 10, 5);

TimeSpan sum = time1.Add(time2);
TimeSpan dif = time1.Subtract(time2);

TimeSpan mult = time2.Multiply(2.0);
TimeSpan div = time2.Divide(2.0);

Console.WriteLine(time1);
Console.WriteLine(time2);

Console.WriteLine(sum);
Console.WriteLine(dif);

Console.WriteLine(mult);
Console.WriteLine(div);