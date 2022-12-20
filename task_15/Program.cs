Console.WriteLine("Ведите номер дня недели от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 || day == 7)
Console.WriteLine("это выходной день");
else if (day < 1 || day > 7)
 Console.WriteLine("в недели всего 7 дней");
else Console.WriteLine("это рабочий день");
