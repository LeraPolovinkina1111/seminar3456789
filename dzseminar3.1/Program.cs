
string PPalindr(int n)
{  
    int num = 10000;
    if (n > 100000 || n < 10000)
        return "The number is not five-digit!";
    else        
        while (num > 1)
        {
            if (n / num % 10 != n % 10)
                return "no";
            n /= 10;
            num /= 100;
        }    
        return "yes";
}

Console.WriteLine(PPalindr(int.Parse(Console.ReadLine())));
