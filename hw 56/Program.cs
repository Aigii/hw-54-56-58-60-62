//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
//с наименьшей суммой элементов: 1 строка


int[,] array = new int[4, 3];

FillArrayRandomNumbers(array);
PrintArray(array);

int min = Int32.MaxValue;
int count = 0;
for(int i = 0; i < array.GetLength(0); i++) 
            {
                 int sum = 0;
                 for(int j = 0; j < array.GetLength(1); j++) 
                 {  
                     sum += array[i, j];  
                     } 
                 if(sum < min)
                 {   
                    min=sum; count = i + 1; // для удобства  
                 }
                 
             }
     Console.WriteLine($"Наименьшая сумма элементов: {min}");
     Console.WriteLine($"Строка: {count}");



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("");
    }
}


