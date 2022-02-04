using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnayzerProblem;
using MoodAnayzerProblem.UC3;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest4
    {
        /// <summary>
        /// TC 4.1 : Given MoodAnalyse ClassName should Return MoodAnalyse Object.
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyse3(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyse3", "MoodAnalyse3");
            expected.Equals(obj);
        }
        /// <summary>
        /// TC 4.2 : Given Improper ClassName should throw MoodAnalysisException.
        /// </summary>
        [TestMethod]
        public void GivenImproperClassNameShouldThrowMoodAnalysisException()
        {
            string expected = "Class not Found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblem.DemoClass", "DemoClass");
            }
            catch (MoodAnayzerProblem.MoodAnalysisException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        /// <summary>
        /// TC 4.3 : Given Improper Constructor should throw MoodAnalysisException.
        /// </summary>
        [TestMethod]
        public void GivenImproperConstructorNameShouldThrowMoodAnalysisException()
        {
            string expected = "Constructor not Found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("DemoClass", "MoodAnalyse3");
            }
            catch (MoodAnayzerProblem.MoodAnalysisException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}