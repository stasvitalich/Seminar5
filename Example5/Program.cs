//Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний.
//Результат запишите в новом массиве
//Пример: [1 2 3 4 5] => 5 8 3

//Определяем, из скольки элементов будет состоять массив.
//Сразу же здесь запишем в переменную, сколько будет пар в массиве.
Console.WriteLine("Введите количество элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine());
int [] NewArray = new int [elementsCount];
int ArrayPairs = elementsCount / 2;
int division = elementsCount % 2;
Console.WriteLine($"Количество пар в введённом массиве равно {ArrayPairs}");

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

//Напишем метод, который принимает на вход массив, а возвращает 
//первую часть пар массива

int GetFirstPairs (int [] NewArray)
{   
    int MultFirst = 0;
    if (division == 0)
    {
        
        for (int i = 0; i < ArrayPairs; i = i + 1)
        {
            MultFirst = NewArray[i] * NewArray[NewArray.Length - i - 1];
            Console.WriteLine(MultFirst);
        }   
    }

    else
    {
        
        for (int i = 0; i < ArrayPairs; i = i + 1)
        {
            MultFirst = NewArray[i] * NewArray[NewArray.Length - i - 1];
            Console.WriteLine(MultFirst);
        }
        Console.WriteLine(NewArray[ArrayPairs]);   
    }
    return MultFirst;
}
int first = GetFirstPairs(NewArray);