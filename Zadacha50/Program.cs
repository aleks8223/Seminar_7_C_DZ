// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 1, j = 2 -> 2
// i = 4, j = 2 -> такого элемента не существует

Console.Write(" размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(" размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];
Console.Write(" позицию строки: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write(" позицию столбца: ");
int n2 = Convert.ToInt32(Console.ReadLine());
void mas(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
{
Console.WriteLine();
for (j = 0; j < n; j++)
{
randomArray[i,j] = rand.Next(1, 9);
Console.Write($"{randomArray[i,j]} ");
}
Console.WriteLine();
}
}
mas(m,n);
if (m2<1 || n2<1)
Console.Write("Позиции строк не могут быть отрицательными");
else if (m2 <= m+1 && n2 <= n+1)
Console.Write($"Значение элемента равно {randomArray[m2-1,n2-1]} ");
else Console.Write("Такого элемента нет в массиве");

