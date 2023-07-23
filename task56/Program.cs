// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] table = new int[4, 4];
FillArrayRandom(table);
PrintArray(table);
Console.WriteLine();
NumberRowMinSumElements(table); // table - параметр строки. Возвращаемый тип метода - строка


// Функция вывода номера строки с наименьшей суммой элементов 
void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;  // инициализация  переменной с 0вым значением для временного хранения минимального значения эл. строки
    int minSumRow = 0; // инициализация  переменной с 0вым значением для вывода номера строки с минимальной суммой элементов
    int sumRow = 0; // инициализация  переменной с 0вым значением для подсчёта суммы элементов текущей строки
    for (int i = 0; i < table.GetLength(1); i++)
    {
        minRow += table[0, i];
    }
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++) //цикл суммирования эл.строки
        sumRow += table[i, j]; // тело цикла не берётся в скобки так как строка одна,это допустимо 
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0; // переменная суммы строки обнуляется для использования в следующей строке
    }
    Console.Write($"{minSumRow + 1} строка");
}

// Функция вывода двумерного массива заполненного рандомными числами
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Функция заполнения массива рандомно числами от 1 до 9
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}