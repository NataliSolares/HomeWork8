// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
Console.Clear();

int[,,] matr = new int[3, 2, 3];

for (int m = 0; m < matr.GetLength(0); m++)
{
    Console.WriteLine($"Page №: {m + 1} ");
    for (int n = 0; n < matr.GetLength(1); n++)
    {
        for (int k = 0; k < matr.GetLength(2); k++)
        {
            matr[m, n, k] = new Random().Next(11, 99);
            Console.Write($"Элемент: {matr[m, n, k]}");
            Console.Write($" Индекс: {m},{n},{k}; ");
        }
        Console.WriteLine();
    }
}

int[] temp = new int[matr.GetLength(0) * matr.GetLength(1) * matr.GetLength(2)];
int num;
for (int i = 0; i < temp.GetLength(0); i++)
{
    temp[i] = new Random().Next(10, 100);
    num = temp[i];
    if (i >= 1)
    {
        for (int j = 0; j < i; j++)
        {
            while (temp[i] == temp[j])
            {
                temp[i] = new Random().Next(10, 100);
                j = 0;
                num = temp[i];
            }
            num = temp[i];
        }
    }
}
int count = 0;
for (int x = 0; x < matr.GetLength(0); x++)
{
    for (int y = 0; y < matr.GetLength(1); y++)
    {
        for (int z = 0; z < matr.GetLength(2); z++)
        {
            matr[x, y, z] = temp[count];
            count++;
        }
    }
}