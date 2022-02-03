using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnayzerProblem.UC3;
using System;

namespace MoodAnalyzerProblem
{
    [TestClass]
    public class UnitTest3
    {
        /// <summary>
        /// TC 3.1: Given NULL Should Throw MoodAnalysisException.
        /// </summary>
        [TestMethod]
        public void Given_NULL_Mood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyse3 moodAnalyse = new MoodAnalyse3(message);
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }

        /// <summary>
        /// TC 3.2: Given Empty Mood Should Throw MoodAnalysisException Indicating EmptyMood.
        /// </summary>
        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyse3 moodAnalyse = new MoodAnalyse3(message);
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
    }
}