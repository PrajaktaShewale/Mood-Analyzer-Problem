using MoodAnalyzer;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Mood Anlyzer");
        AnalyzeMood mo = new AnalyzeMood();
        mo.Mood("sad");
    }

}

