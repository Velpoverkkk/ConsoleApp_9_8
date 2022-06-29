using System;
class Program
{   //Вычислить y=sqrt(1+sqrt(2+sqrt(n))) (с применением рекурсии и без неё)
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int n, x, a = 0;
        System.Console.WriteLine("Chislo N");
        n = System.Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Norm(n));
        Console.WriteLine(Rec(n-1, Math.Sqrt(n)));
    }
    static double Norm(int n)
    {
        double a =Math.Sqrt(n);
        for (int i = n-1; i>0; i--)
        {
            a = Math.Sqrt(a + i);
        }
        return a;
    }
    static double Rec(int n,double a)
    {   
        if (n != 0) return Rec(n - 1,Math.Sqrt(a+n));
        else return a;
    }
}
