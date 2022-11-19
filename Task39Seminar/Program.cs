// Stask39 напишите программу, которая перевернет одномерный массив 
// (последний элемент будет на первом месте, а первый  на последнем и тд)

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
int[] myRandomArray = CreateRandomArray(7, 0, 52);
Console.WriteLine($"Исходный массив:");
ShowArray(myRandomArray);

int[] newArray = new int[myRandomArray.Length];
for (int i = 0; i < myRandomArray.Length; i++)
{
    newArray[i] = myRandomArray[myRandomArray.Length - 1 - i];
}
Console.WriteLine($"Перевернутый массив:");
ShowArray(newArray);