Console.WriteLine("Загадайте любое число: ");
int a = Convert.ToInt32(Console.ReadLine());
string N = SecondNum(a);
Console.WriteLine(N);

string SecondNum(int count)
{
    string output;
    if(count > 99)
    {
        while (count >= 1000) count /= 10;
        int c = count % 10;
        output = "Третья цифра вашего числа = " + c;
    }
    else
    {
        output = "третьей цифры в этом числе нет";
    }
    return output;
}