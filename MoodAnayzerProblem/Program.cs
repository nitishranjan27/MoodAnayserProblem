using System;
using MoodAnayzerProblem;

namespace MoodAnalyzerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyse obj = new MoodAnalyse("Sad");
            obj.AnalyseMood();
        }
    }
}