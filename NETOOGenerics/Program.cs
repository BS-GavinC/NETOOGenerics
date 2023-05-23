using NETOOGenerics;

DateTime date = DateTime.Now;

User<DateTime> user = new User<DateTime>(date);

Console.WriteLine(user.isMyId(date));

