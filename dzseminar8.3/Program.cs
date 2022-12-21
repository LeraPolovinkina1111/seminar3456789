//Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.


void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j],3}  ");
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

int[,] MatrixProduct(int[,] arr1, int[,] arr2)
{
    int row = arr1.GetLength(0);
    int column = arr1.GetLength(1);
    int[,] prmatr = new int[row, column];

    if (row != arr2.GetLength(0) || column != arr2.GetLength(1))
     return prmatr;
    
    for (int i = 0; i < row; i++)       
        for (int j = 0; j < column; j++)
            prmatr[i, j] = arr1[i, j] * arr2[i, j];            
    return prmatr;
}


Console.Write("Enter the number of rows 1: ");
int row_1 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns 1: ");
int column_1 = int.Parse(Console.ReadLine());

Console.Write("Enter the number of rows 2: ");
int row_2 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns 2: ");
int column_2 = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row_1, column_1, 0, 5);
Print(arr_1);
int[,] arr_2 = MassNums(row_2, column_2, 0, 5);
Print(arr_2);

int[,] res_matrix = MatrixProduct(arr_1, arr_2);
Print(res_matrix);
