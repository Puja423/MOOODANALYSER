using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodANALYSER;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMood_ReturnSad()
        {
            string expected = "SAD";
            string message = "I am Sad now";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);

        }

        [TestMethod]
        public void GivenMood_ReturnHappy()
        {

            string expected = "HAPPY";
            string message = "I am in any mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);


        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void GivenNullMood_ReturnHappy()
        {
            string expected = "HAPPY";
            string message = "HAPPY";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            string mood = moodAnalyzer.CheckMood();
            Assert.AreEqual(expected, mood);
        }
    }
}

