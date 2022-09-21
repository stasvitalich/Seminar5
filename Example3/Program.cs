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


//Console.WriteLine();
//Console.WriteLine ("Введите число для поиска в массиве: ");
//int FindNumber = int.Parse(Console.ReadLine());

Console.WriteLine();

 Console.Write("Введите число, которое хотите найти в массиве: ");
            int number = int.Parse(Console.ReadLine());
 
            int pos = -1;
            for (int j = 0; j < NewArray.Length; j++)
            {
                if (number == NewArray[j]) { pos = j; break; }
            }
            if (pos >= 0) Console.WriteLine($"Да, элемент {number} находится в массиве.");
            else Console.WriteLine($"Нет, элемента {number} нет в массиве.");
