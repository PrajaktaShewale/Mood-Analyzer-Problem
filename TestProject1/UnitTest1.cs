using MoodAnalyzer;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GiveMoodShouldReturnSadMood()
        {
            const string happymood = "Happy";
            const string sadmood = "Sad";
            AnalyzeMood mood = new AnalyzeMood();
            string Actualresult = mood .Mood(happymood);
            string expected = "Happy";
            Assert.AreEqual(expected, Actualresult);
            
        }
    }
}