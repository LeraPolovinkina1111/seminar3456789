
double Distance(int ax,int ay,int az,int bx,int by,int bz)
{
    double result;
    result=Math.Sqrt(Math.Pow(bx-ax,2)+Math.Pow(by-ay,2)+Math.Pow(bz-az,2));
    return result;
}

Console.WriteLine(Distance(3, 6, 8, 2, 1, -7));
Console.WriteLine(Distance(7, -5, 0, 1, -1, 9));