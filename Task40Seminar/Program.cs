// Task40 напишите программу которая на вход принимает три числа и проверяет, может ли сушествовать 
// треугольник с сторонами такой длины

int[] CreateRandomArray(int N, int start, int end)//рандомный по параметрам
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
void ShowArray(int[] array) //ввыод массива на экран
{ 
for (int i = 0; i < array.Length; i++)
{
   Console.Write(array[i] + " "); 
}
Console.WriteLine();
}
int[] myRandomArray = CreateRandomArray(3, 1, 10);
Console.WriteLine($"Длины сторон триугольника:");
ShowArray(myRandomArray);

if ((myRandomArray[0] + myRandomArray[1]) < myRandomArray[2] && (myRandomArray[2] + myRandomArray[1]) < myRandomArray[0] && (myRandomArray[0] + myRandomArray[2]) < myRandomArray[1])
{
    Console.WriteLine($"Триугольник существует");
}
else
{
    Console.WriteLine($"Тригольник не существует");
}