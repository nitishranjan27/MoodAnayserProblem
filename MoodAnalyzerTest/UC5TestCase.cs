﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnayzerProblem;
using MoodAnayzerProblem.UC3;

namespace MoodAnalyzerProblemTest
{
    [TestClass]
    public class UnitTest5
    {
        /// <summary>
        /// TC 5.1 : Given MoodAnalyse ClassName Should Return MoodAnalyser Object.
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyse3("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerApp.MoodAnalyse3",
                "MoodAnalyse3", "HAPPY");
            expected.Equals(obj);
        }

        /// <summary>
        /// TC 5.2 : Given Improper ClassName Should Throw MoodAnalysisException.
        /// </summary>
        [TestMethod]
        public void GivenImproperClassNameShouldThrowMoodAnalysisException_UsingParameterizedConstructor()
        {
            string expected = "Class not Found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerApp.DemoClass",
                "MoodAnalyse3", "HAPPY");
            }
            catch (MoodAnayzerProblem.MoodAnalysisException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        /// <summary>
        /// TC 5.3 : Given Improper ConstructorName Should Throw MoodAnalysisException.
        /// </summary>
        [TestMethod]
        public void GivenImproperConstructorNameShouldThrowMoodAnalysisException_UsingParameterizedConstructor()
        {
            string expected = "Constructor not Found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerApp.MoodAnalyse3",
                "DemoConstructor", "HAPPY");
            }
            catch (MoodAnayzerProblem.MoodAnalysisException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}