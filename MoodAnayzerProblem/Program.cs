using System;
using MoodAnayzerProblem;

namespace MoodAnalyzerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UC1
            UC1_MoodAnalyse obj = new UC1_MoodAnalyse("Sad");
            obj.AnalyseMood();
        }
    }
}