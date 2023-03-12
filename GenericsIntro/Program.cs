using GenericsIntro;

internal class Program
{
    private static void Main(string[] args)
    {
        MyList<string> myList=new MyList<string>();
        myList.Add("Mikail");
        Console.WriteLine("Hello, World!");
    }
}