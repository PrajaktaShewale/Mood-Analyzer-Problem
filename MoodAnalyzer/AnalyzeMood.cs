using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class AnalyzeMood
    {
        public const string Happy_Mood = "Happy";
        public const string Sad_Mood = "Sad";
        public string Mood(string mood)
        {
            if (mood.ToLower().Contains("happy"))
            {
                Console.WriteLine(Happy_Mood);
                return mood;
            }
            if (mood.ToLower().Contains("sad"))
            {
                Console.WriteLine("I M in "+Sad_Mood + "mood");
                return mood;
            }
            else
            {
                return null;
            }
        }
    }
}
