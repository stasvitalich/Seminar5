﻿//Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива,
//значения которых лежат в отрезке [10, 99]

//Строго задаём массив из 123 элементов: 
int [] NewArray = new int [123];

//Задаём переменную для заполнения массива рандомными числами
Random rand = new Random();

//Через цикл for инициализируем ввод элементов массива 
//в пределах заданной длины числами от 1 до 123
for(int i = 0; i < NewArray.Length; i = i + 1)
{
    NewArray[i] = rand.Next(1, 123);
}

//Вывод массива
Console.WriteLine();
Console.Write("Вывод массива из 123 элементов, заполненных рандомными числами от 1 до 123: ");
for (int i = 0; i < NewArray.Length; i = i + 1)
{   
    Console.Write($"{NewArray[i]}, ");
}
Console.WriteLine("");

Console.WriteLine("Найдём количество элементов, лежащих на отрезке массива [10, 99]");
//Напишем метод, который на вход принимает массив, а возвращает число
//Введём новую переменную sum. Если отдельно взятое число массива больше или равно 10,
//мы прогоняем его по второму кругу условия if, проверяя, что оно меньше или равно 99. 
//Если оба условия соблюдены, то мы прибавляем к сумме 1.
int QuantityOfExactElements (int [] NewArray)
{
    int sum = 0;
    for (int i = 0; i < NewArray.Length; i = i + 1)
    {
        if (NewArray[i] >= 10)
        {
            if (NewArray[i] <= 99)
            {
                sum = sum + 1;
            }
        }
    }
    return sum;
}

//Выводим метод на печать в консоль
int result = QuantityOfExactElements(NewArray);
Console.WriteLine(result);