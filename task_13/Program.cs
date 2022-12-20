Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string stringnum = Convert.ToString(num);
if(stringnum.Length > 2) Console.WriteLine($"третья цифра: {stringnum[2]}");
else Console.WriteLine("это не трехзначное");