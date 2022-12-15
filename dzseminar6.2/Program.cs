void Peresechenija(double k1, double b1, double k2, double b2)
{
    double tpsch = k1- k2;
    if (tpsch != 0)
    {
        double x = (b2 - b1) / (k1- k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Peresechenija point: ({x}; {y})");
    }
    else if (k1 == k2 && b1 == b2)
        Console.WriteLine("There are an infinite number of intersection points.");
    else
        Console.WriteLine("There is no intersection point");
}

Peresechenija(int.Parse(Console.ReadLine()),
             int.Parse(Console.ReadLine()),
             int.Parse(Console.ReadLine()),
             int.Parse(Console.ReadLine()));
