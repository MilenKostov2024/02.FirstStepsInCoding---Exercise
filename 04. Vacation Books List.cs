int bookPages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int dayToRead = int.Parse(Console.ReadLine());

int readingHoursPerDay = bookPages / pagesPerHour / dayToRead;

Console.WriteLine(readingHoursPerDay);