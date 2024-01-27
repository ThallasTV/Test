public class Program
{

    public int Sum(int a, int b)
    {
        return a+b;
    }

    public int Remainder(int x, int y)
    {
        return x % y;
    }

    public int TriArea(int b, int h)
    {
        return b*h/2;
    }

    public int Convert(int minutes)
    {
        return minutes * 60;
    }

    public bool LessThan100(int a, int b)
    {
        if(a + b < 100)
            return true;
        else
            return false;
    }
    
    public int Addition(int num)
    {
        return ++num;
    }

    public bool LessThanOrEqualToZero(double a) => a <= 0 ? true : false;

    public string GiveMeSomething(string a)
    {
        return $"something {a}";
    }
    
    // public int GetAbsSum(int[] arr)
    // {
        
    // }
    private static void Main(string[] args)
    {
        var chall = new Program();
        Console.WriteLine("Challenge #1: " + chall.Sum(3,2));
        Console.WriteLine("Challenge #2: " + chall.Remainder(1,3));
        Console.WriteLine("Challenge #3: " + chall.TriArea(7,4));
        Console.WriteLine("Challenge #4: " + chall.Convert(4));
        Console.WriteLine("Challenge #5: " + chall.LessThan100(50,21));
        Console.WriteLine("Challenge #6: " + chall.Addition(1));
        Console.WriteLine("Challenge #7: " + chall.LessThanOrEqualToZero(0));
        
    }
}