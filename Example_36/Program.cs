// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

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

int Sum(int[] result)
{
    int count = 0;
    for(int i = 0; i < result.Length; i++)
    {
        if(i % 2 != 0)
        {
            count += result[i];
        }
    }
    return count;
}

int[] array = GetArray(10, 100, 110);
Console.WriteLine(String.Join(" , ", array));
int oddSum = Sum(array);
Console.WriteLine(oddSum);
