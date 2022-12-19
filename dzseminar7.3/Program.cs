//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.



void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

int SrArifm(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int sredarifm = 0;

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            if (i == j)
                sredarifm += arr[i, j];

    return sredarifm;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);

Console.Write(SrArifm(arr_1));
