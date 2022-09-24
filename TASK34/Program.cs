//Задача 34 
//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//Пример: [345, 897, 568, 234] -> 2

//В условии задачи не сказано, сколько должно быть эл-ов в массиве.
//Пусть будет 8 эл-ов: 
int [] NewArray = new int [8];

//Задаём переменную для заполнения массива рандомными числами
Random rand = new Random();

//Через цикл for инициализируем ввод элементов массива 
//в пределах заданной длины числами от 100 до 1000
for(int i = 0; i < NewArray.Length; i = i + 1)
{
    NewArray[i] = rand.Next(100, 999);
}

//Вывод массива
Console.WriteLine();
Console.Write("Инициирован массив: [");
for (int i = 0; i < NewArray.Length; i = i + 1)
{   
       if (i < 7)
        {
            Console.Write($"{NewArray[i]}, ");
        }
        else
        {
            Console.Write($"{NewArray[i]}");
        }   
    //Console.Write($"{NewArray[i]}, ");
}
Console.Write("]");

//Напишем метод, которы будет счиать кол-во чётных чисел в массиве
Console.WriteLine("");
Console.Write("Количество чётных чисел в массиве: ");

int GetEven (int [] NewArray)
{
    int sum = 0;
    for (int i = 0; i < NewArray.Length; i = i + 1)
    {
        if (NewArray[i]%2 == 0)
        sum = sum + 1;
    }
    return sum;
}

//Через новую переменную выведем массив на печать
int totalEven = GetEven(NewArray);
Console.Write(totalEven);
