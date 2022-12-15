void Peresechenija(double x1, double y1, double x2, double y2)
{
    double tpsch = x1- x2;
    if (tpsch != 0)
    {
        double x = (y2 - y1) / (x1- x2);
        double y = x1 * x + y1;
        Console.WriteLine($"Peresechenija point: ({x}; {y})");
    }
    else if (x1 == x2 && y1 == y2)
        Console.WriteLine("There are an infinite number of intersection points.");
    else
        Console.WriteLine("There is no intersection point");
}

Peresechenija(int.Parse(Console.ReadLine()),
             int.Parse(Console.ReadLine()),
             int.Parse(Console.ReadLine()),
             int.Parse(Console.ReadLine()));
