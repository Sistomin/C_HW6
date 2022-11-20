// Task44 Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1
// если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Сколько чисел Фибоначчи вывести на экран?");
int size = int.Parse(Console.ReadLine());

int[] fibs = new int[size];
for (int i = 0; i < 2; i++)
{
    fibs[i] = i;
}

for (int j = 2; j < fibs.Length; j++)
{
    fibs[j] = fibs[j-1] + fibs[j-2];
}

Console.WriteLine($"Первые {size} чисел Фибоначчи: [ {String.Join(", ", fibs)} ]");