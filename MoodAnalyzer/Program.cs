using MoodAnalyzer;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Mood Anlyzer");
        Console.WriteLine("Enter message ");
        string message = Console.ReadLine();

        AnalyzeMood mo = new AnalyzeMood(message);
        string mood = mo.MoodAnalyzer();//calling method of class with passing user message as parameter
        Console.WriteLine($"{mood} MOOD");
        Console.ReadLine();
    }

}

