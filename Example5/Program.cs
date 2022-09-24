//Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний.
//Результат запишите в новом массиве
//Пример: [1 2 3 4 5] => 5 8 3

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
Console.Write("Вывод массива: [");
for (int i = 0; i < NewArray.Length; i = i + 1)
{   
    Console.Write($"{NewArray[i]} ");
}
Console.Write("]");

//Пытаемся найти произведение пар массива
Console.WriteLine();
Console.WriteLine("Найдём произведение пар массива: ");

Console.Write("Вывод массива: ");
for (int i = 0; i < NewArray.Length; i = i + 1)
{   
    int mult = NewArray[0] * NewArray [NewArray.Length];
    Console.Write($"{NewArray[i]} ");
}