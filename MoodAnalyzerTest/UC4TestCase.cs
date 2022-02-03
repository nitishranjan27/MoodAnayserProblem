﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnayzerProblem;
using MoodAnayzerProblem.UC3;

namespace MoodAnalyzerProblem
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
           
                string message = null;
                object expected = new MoodAnalyse3(message);
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyse3", "MoodAnalyse3");
                expected.Equals(obj);
        }

        [TestMethod]
        public void GivenClassNameWhenImproperShouldThrowMoodAnalysisException()
        {
            try
            {
                string message = null;
                object expected = new MoodAnalyse3(message);
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyse3", "MoodAnalyse3");
                expected.Equals(obj);
            }
            catch (MoodAnayzerProblem.MoodAnalysisException ex)
            {
                Assert.AreEqual("Class not Found", ex.Message);
            }
        }

        [TestMethod]
        public void GivenClassWhenConstuctorNotProperShouldThrowMoodAnalysisException()
        {
            try
            {
                string message = null;
                object expected = new MoodAnalyse3(message);
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyse3", "MoodAnalyse3");
                expected.Equals(obj);
            }

            catch (MoodAnayzerProblem.MoodAnalysisException ex)
            {
                Assert.AreEqual("Constructor not Found", ex.Message);
            }
        }
    }
}