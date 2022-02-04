using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnayzerProblem;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        [DataRow(null)]
        public void GivenHAPPYMoodShouldReturnHappy(string message)
        {
            // Arrange
            string expected = "HAPPY";
            MoodAnalyse2 moodAnalyzer = new MoodAnalyse2(message);

            //Act
            string mood = moodAnalyzer.AnalyseMood();

            // Assert
            Assert.AreEqual(expected, mood);
        }
    }
}