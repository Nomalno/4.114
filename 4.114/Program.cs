Console.Write("Год: ");
int year = int.Parse(Console.ReadLine());
 Console.WriteLine("Номер месяца: ");
int mounth = int.Parse(Console.ReadLine());
Console.WriteLine("День: ");
int day = int.Parse(Console.ReadLine());
Console.WriteLine($"Дата предыдущего дня: {day - 1}.{mounth}.{year}");
Console.WriteLine($"Дата следующего дня: {day + 1}.{mounth}.{year}");
  if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
 {
                Console.WriteLine("Год високосный");
}
  else
{
                Console.WriteLine("Год не високосный");
}