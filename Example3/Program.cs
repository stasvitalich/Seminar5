//Задайте массив. Напишите программу, которая определяет,
//присутствует ли заданное число в массиве.
//Пример1: 4; массив [6, 7, 19, 345, 3] -> нет
//Пример2: 3; массив [6, 7, 19, 345, 3] -> да

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
Console.Write("Вывод массива: ");
for (int i = 0; i < NewArray.Length; i = i + 1)
{   
    Console.Write($"{NewArray[i]}, ");
}


Console.WriteLine();
Console.WriteLine ("Введите число для поиска в массиве: ");
int FindNumber = int.Parse(Console.ReadLine());

Console.WriteLine();
for (int i = 0; i < NewArray.Length; i = i + 1)
{   
    if (NewArray[i] == FindNumber)
    {
        Console.WriteLine($"Да, число {FindNumber} присутствует в введённом вами массиве");
        break;
    }
    else
    {
        Console.WriteLine($"Нет, число {FindNumber} не присутствует в введённом вами массиве");
    }
}
