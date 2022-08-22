Console.Write("Введите число дня недели. Где 1 - это Понедельник, а 7 - это воскресенье: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(WeekDay(a));

string WeekDay(int count)
{
    string day;
    if(count == 1) day = "Понедельник";
    else if (count == 2) day = "Вторник";
    else if (count == 3) day = "Среда";
    else if (count == 4) day = "Четверг";
    else if (count == 5) day = "Пятница";
    else if (count == 6) day = "Суббота";
    else if (count == 7) day = "Воскресенье";
    else day = "Вы ввели не верное число";
    return day;
}