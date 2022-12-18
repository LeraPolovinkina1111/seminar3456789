void Print(double[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]}  ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] MassSimple(int row, int column)
{
    double[,] arr = new double[row, column];
    Random nneww = new Random();
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i,j] = Math.Round(nneww.NextDouble() * -10, 2);;

    return arr;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

double[,] arr_1 = MassSimple(row, column);
Print(arr_1);
