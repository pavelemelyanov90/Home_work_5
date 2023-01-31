// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = minValue + new Random().NextDouble() * (minValue - maxValue);       
    }
    return res;
}

double MaxNum(double[] result)
{
    double max = result[0];
    for(int i = 0; i < result.Length; i++)
    {
        if(result[i] > max)
        {
            max = result[i];          
        }                
    }
    return max;
    
}

double MinNum(double[] res)
{
    double min = res[0];
    for(int i = 0; i < res.Length; i++)
    {
        if(res[i] < min)
        {
            min = res[i];          
        }        
    }
    return min;
    
}

double[] array = GetArray(10, 10, 20);
Console.WriteLine(String.Join(" ; ", array));
double maximum = MaxNum(array);
double minimum = MinNum(array);
Console.Write($"Разница между {maximum} и {minimum} равна {maximum - minimum}");
