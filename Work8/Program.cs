Console.WriteLine("Zadacha54 \n");
void Zadacha54()
{
    //Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит
    // по убыванию элементы каждой строки двумерного массива.
    int rows = 5;
    int columns = 5;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, 0, 20);
    PrintArray(numbers);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                if (numbers[i, k] < numbers[i, j])
                {
                    int t = numbers[i, k];
                    numbers[i, k] = numbers[i, j];
                    numbers[i, j] = t;
                }
            }
        } 
    }
    Console.WriteLine();
    Console.WriteLine("Массив по убыванию элементов строки \n");
    PrintArray(numbers);
}
Zadacha54();

void FillArray(int[,] numbers, int minValue, int maxValue)
{
    maxValue++;
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = rand.Next(minValue, maxValue);
        }
    }
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
Console.WriteLine("Zadacha56 \n");
void Zadacha56()
{
    // Задача 56. Задайте прямоугольный двумерный массив. Напишите программу,
    //  которая будет находить строку с наименьшей суммой элементов.
    int rows = 3;
    int columns = 5;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, 0, 5);
    PrintArray(numbers);
    int sum = 0;
    int sum1 = 0;
    int sum2 = 0;
    Console.WriteLine();
    for (int i = 0; i < rows - i - 1; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sum += numbers[0, j];
            sum1 += numbers[1, j];
            sum2 += numbers[2, j];
        }
        Console.WriteLine("cумма 1 строки = " + sum);
        Console.WriteLine("cумма 2 строки = " + sum1);
        Console.WriteLine("cумма 3 строки = " + sum2);
        Console.WriteLine();
        if (sum1 <= sum && sum1 <= sum2)
            Console.WriteLine("строка с наименьшей суммой элементов: 2");
        else if (sum2 <= sum1 && sum2 <= sum)
            Console.WriteLine("строка с наименьшей суммой элементов: 3");
        else if (sum <= sum2 && sum <= sum1)
            Console.WriteLine("строка с наименьшей суммой элементов: 1");
    }
}
Zadacha56();
