// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);       
    }
    return res;
}

int countPos(int[] result)
{
    int count = 0;
    for(int i = 0; i < result.Length; i++)
    {
        if(result[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = GetArray(10, 100, 110);
Console.WriteLine(String.Join(" , ", array));
int countPositive = countPos(array);
Console.WriteLine(countPositive);
