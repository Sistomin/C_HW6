// Task42 напишите программу, которая будет преобразовывать десятичное число в двоичное

string ToBin(int num)
{
    string result = "";
    string temp = "";
    while (num > 0)
    {
        temp = Convert.ToString(num%2);
        result = temp + result;
        num = num / 2;
    }
    return result;
}
Console.WriteLine(ToBin(2));