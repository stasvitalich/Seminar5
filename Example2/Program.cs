//Напишите программу замена элементов массива:
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//Пример: [-4, -8, 8, 2] -> [4, 8, -8, -2] 

//Определяем, из скольки элементов будет состоять массив
Console.WriteLine("Введите количество лементов массива: ");
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
Console.Write("Вывод массива: ");
for (int i = 0; i < NewArray.Length; i = i + 1)
{   
      Console.Write($"{NewArray[i]}, ");
}

//Выводим обратную версию массива. 
//Если элемент меньше нуля, берём его по модулю.
//Если элемент больше нуля, умножаем его на -1
Console.WriteLine();
Console.Write("Вывод обратного массива: ");
for (int i = 0; i < NewArray.Length; i = i + 1)
{     
    if (NewArray[i] < 0)
    {
        Console.Write($"{Math.Abs(NewArray[i])}, ");
    }
    else
    {
        Console.Write($"{-1*NewArray[i]}, ");
    }
}