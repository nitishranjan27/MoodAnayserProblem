using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnayzerProblem
{
    public class MoodAnalysisException : Exception
    {
        /// <summary>
        /// MoodAnalysisException Class for Handling Exception.
        /// </summary>
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
            NO_SUCH_FIELD, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE,
            NULL_VALUE
        }

        // Creating 'type' variable of type ExceptionType
        private readonly ExceptionType type;

        public MoodAnalysisException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}