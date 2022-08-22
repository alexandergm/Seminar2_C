Console.WriteLine("Введите 3х значное число: ");
int a = Convert.ToInt32(Console.ReadLine());
a = a / 10 % 10;
Console.WriteLine("Вторая цифра загаданного число это: " + a);
