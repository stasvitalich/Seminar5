//Задача 36
//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//Пример: 
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//В условии задачи не сказано, сколько должно быть эл-ов в массиве.
//Пусть будет 8 эл-ов: 
int [] NewArray = new int [8];

//Задаём переменную для заполнения массива рандомными числами
Random rand = new Random();

//Через цикл for инициализируем ввод элементов массива 
//в пределах заданной длины числами от -100 до 100
for(int i = 0; i < NewArray.Length; i = i + 1)
{
    NewArray[i] = rand.Next(-100, 100);
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

//Напишем метод, которы будет счиать кол-во элементов, 
//находящихся на чётных позициях в массиве
Console.WriteLine("");
Console.Write("Сумма элементов на нечётных позициях: ");

int GetEven (int [] NewArray)
{
    int sum = 0;
    for (int i = 0; i < NewArray.Length; i = i + 1)
    {
        if (i%2 == 1)
        {
            sum = sum + NewArray[i];
        }
    }    
    return sum;
}

//Через новую переменную выведем массив на печать
int totalEven = GetEven(NewArray);
Console.Write(totalEven);
