//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.

//Пишем метод, который на вход принимает массив, стартовое и финальное значение.
int [] GetArray(int size, int startValue, int endValue)
{   
    var array = new int[size];
    var random = new Random();
    for (int i = 0; i < array.Length; i = i + 1)
    {
        array[i] = random.Next(startValue, endValue + 1);
    }
    return array;
}

//Пишем метод, который находит сумму положительных элементов массива
int GetSumPositiveElements(int [] array)
{
    var sum = 0;
    for (int i = 0; i < array.Length; i = i + 1)
    {
        if (array[i] > 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

//Пишем метод, который находит сумму отрицательных элементов массива
int GetSumNegativeNumbers(int [] array)
{
    var sum = 0;
    for (int i = 0; i < array.Length; i = i + 1)
    {
        if (array[i] < 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}


int [] array = GetArray(12, -9, 9);
int sumPositive = GetSumPositiveElements(array);
int sumNegative = GetSumNegativeNumbers(array);
Console.WriteLine($"Cумма положительных чисел равна {sumPositive}");
Console.WriteLine($"Cумма отрицательных чисел равна {sumNegative}");