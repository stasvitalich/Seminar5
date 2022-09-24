//Задача 38
//Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
//Пример: [3 7 22 2 78] -> 76

//Определяем, из скольки элементов будет состоять массив
Console.WriteLine("Введите количество элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine());
int [] NewArray = new int [elementsCount];

//Заполняем наш массив вручную
for(int i = 0; i < NewArray.Length; i = i + 1)
{
    Console.WriteLine($"Введите элемент массива с индексом {i}");
    NewArray[i] = int.Parse(Console.ReadLine());
}

//Выводим введённый ранее массив
Console.WriteLine();
Console.Write("Инициирован массив: [");
for (int i = 0; i < NewArray.Length; i = i + 1)
{   
      if (i < elementsCount - 1)
        {
            Console.Write($"{NewArray[i]}, ");
        }
        else
        {
            Console.Write($"{NewArray[i]}");
        }   
}
Console.Write("]");

//Напишем метод, которы находит максимум в массиве.
//Метод принимает на вход массив, а возвращает число

Console.WriteLine("");

int GetMax (int [] NewArray)
{
    int max = NewArray[0];
    for (int i = 0; i < NewArray.Length; i = i + 1)
    {
        if (NewArray[i] > max)
        {
            max =  NewArray[i];
        }
    }    
    return max;
}

int MaximumNumber = GetMax(NewArray);

//Напишем метод, который находит минимум в массиве.
//Метод принимает на вход массив, а возвращает число

Console.WriteLine("");

int GetMin (int [] NewArray)
{
    int min = NewArray[0];
    for (int i = 0; i < NewArray.Length; i = i + 1)
    {
        if (NewArray[i] < min)
        {
            min =  NewArray[i];
        }
    }    
    return min;
}

int MinimumNumber = GetMin(NewArray);
Console.Write($"Разница между максимальным элементом {MaximumNumber} и минимальным элементом {MinimumNumber}: {MaximumNumber - MinimumNumber}");
