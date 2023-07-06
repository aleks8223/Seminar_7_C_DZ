// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое* элементов в каждом столбце.

Console.Write("Введите размерность m массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите размерность n массива: ");
int n = int.Parse(Console.ReadLine()!);
int[,] randomArray = new int[m, n];

// Метод заполнения двумерного массива
void GetMassive(int m, int n)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.Next(1, 9);
            Console.Write($"{randomArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Метод вывода арифметического числа
void ArithmeticNumber(int m, int n)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    int i, j;
    Random rand = new Random();
    for (j = 0; j < n; j++)
    {
        double sum = 0;
        for (i = 0; i < m; i++)
        {
            sum = sum + randomArray[i, j];
        }
        Console.Write($"{sum / (i):F1}; ");
    }
}
GetMassive(m, n);
ArithmeticNumber(m, n);