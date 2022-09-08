// Найти произведение двух матриц
int[,] matr = new int[2, 2];
int[,] matr1 = new int[2, 2];

for (int m = 0; m < matr.GetLength(0); m++)
{
    for (int n = 0; n < matr.GetLength(1); n++)
    {
        matr[m, n] = new Random().Next(1, 10);
        Console.Write($"{matr[m, n]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int m = 0; m < matr1.GetLength(0); m++)
{
    for (int n = 0; n < matr1.GetLength(1); n++)
    {
        matr1[m, n] = new Random().Next(1, 10);
        Console.Write($"{matr1[m, n]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int[,] compMatr = new int[2, 2];
for (int m = 0; m < matr.GetLength(0); m++)
{
    for (int n = 0; n < matr.GetLength(1); n++)
    {
        compMatr[m, n] = matr[m, n] * matr1[m, n];
    Console.Write($"{compMatr[m, n]} ");
    }
    Console.WriteLine();
}

