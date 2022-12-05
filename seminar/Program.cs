//void Quarters(int x,int y)
//{
//    if(x==0||y==0)
//    Console.WriteLine("x=0 or y=0");
//    else if(x>0 && y>0)
//    Console.WriteLine("I");
//    else if(x<0 && y>0)
//    Console.WriteLine("II");
//    else if(x<0 && y<0)
//    Console.WriteLine("III");
//    else if(x<0 && y>0)
//    Console.WriteLine("IV");
//}

//Quarters(-10,9);




//void Quarters(string a)
//{
//    if(a=="I")
//    Console.WriteLine("x>0 or y>0");
//    else if(a=="II")
//    Console.WriteLine("x<0 or y>0");
//    else if(a=="III")
//    Console.WriteLine("x<0 or y<0");
//    else if(a=="IV")
// /   Console.WriteLine("x>0 or y<0");
//    else 
//    Console.WriteLine("error");
//}

//Quarters(Console.ReadLine());


int ReadNumber(string message)
{
    Console.WriteLine(message);
    var s=Console.ReadLine();
    int a =s ==null? 0:int.Parse(s);
    return a;
}
double Distance(int ax,int bx,int ay,int by)
{
    double result;
    result=Math.Sqrt(Math.Pow(bx-ax,2)+Math.Pow(by-ay,2));
    return result;
}






int ax=ReadNumber("Введите X:");
int ay=ReadNumber("Введите Y:");
int bx=ReadNumber("Введите X:");
int by=ReadNumber("Введите Y:");

Console.WriteLine(Distance(ax,ay,bx,by));
