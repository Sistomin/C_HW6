// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write("Введите числа (через пробел): ");
int[] arr = GetArrayFromString(Console.ReadLine());
Console.WriteLine($"Кол-во элементов больше нуля: {GetCountPositiveElements(arr)}");

int[] GetArrayFromString(string stringArray) //метод в котором разбиваем введеную пользователем стороку на элементы
// (разделение пробелами), и парсим в числа, затем собираем массив из чисел 
{
    string[] numString = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] numResult = new int[numString.Length];
    for (int i = 0; i < numResult.Length; i++)
    {
        numResult[i] = int.Parse(numString[i]);
    }
    return numResult; // возращаем массив чисел numResult
}

int GetCountPositiveElements(int[] numResult) // метод который делает проверку больше ли нуля число в массиве numResult
{
int count = 0;
foreach (var item in numResult)
{
    if (item > 0) count++;
}
return count;
}