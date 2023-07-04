// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными(тип double) числами.


Console.Write("Введите количество строк двумерного массива m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк двумерного массива n: ");
int n = int.Parse(Console.ReadLine()!);
double[,] randomArray = new double[m, n];
Random rand = new Random();

// Метод вывода чисел двумерного массива.
void PrintArray(double[,] massive)
{
    int i, j;
    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (j = 0; j < n; j++)
        {
            Console.Write($"{randomArray[i, j]} ");
        }
    }
}

// Метод создания двумерного массива со случайными вещественными числами.
void FillArray(double[,] massive)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            massive[i, j] = Convert.ToDouble(rand.Next(-100, 100) / 10.0);
        }
    }
}
FillArray(randomArray);
Console.WriteLine();
PrintArray(randomArray);






