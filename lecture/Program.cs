//string[,]table=new string[2,5];
//table[1,2]="world";
//for (int rows = 0; rows < 5; rows++)
//{
//   for (int colums = 0; colums < 5; colums++)
//   {
//       Console.WriteLine($"-{table[rows,colums]}-");
//    }     
//}


//void PrintArray(int[,] matr)
//{
//  for (int i = 0; i < matr.GetLength(0); i++)
//{
//  for (int j = 0; j < matr.GetLength(0); j++)
//{
//  Console.Write($"{matr[i, j]} ");
//}
//     Console.WriteLine();
//  }
//}

//void FillArray(int[,]matr)
//{
//    for (int i = 0; i < matr.GetLength(0); i++)
//{
//   for (int j = 0; j < matr.GetLength(0); j++)
//     {
//           matr[i,j]=new Random().Next(1,10);
//        }

//    }
//}




//int[,]matrix=new int[3, 4];


//PrintArray(matrix);
//FillArray(matrix);
//PrintArray(matrix);




int Factorial(int n)
{
    if (n == 1) return 1;
    else return n*Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine(Factorial(i));
}

