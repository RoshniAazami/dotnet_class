using System; //overloading constructor
class Cons
{
    private int sum;
    public Cons (int a, int b)
    {
        sum=a+b;
        Console.WriteLine("sum={0}", sum);
    }
    public Cons(int a, int b, int c)
    {
        sum=a+b+c;
        Console.WriteLine("sum={0}",sum);
    }
}
class Program
{
    static void Main(String[]args)
    {
        new Cons(10,20);
        new Cons(10,20,30);
    }
}
//output
//sum=30
//sum=60