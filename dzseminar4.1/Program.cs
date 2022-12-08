void Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}


int Enter(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int numberA = Enter("Введите число A: ");
int numberB = Enter("Введите число B: ");
Degree(numberA, numberB);
