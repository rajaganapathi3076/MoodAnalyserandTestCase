using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeAnalyser
{
    internal class InvalidMoodException:Exception
    {
        ExceptionTypes exceptionTypes;
        public enum ExceptionTypes
        {
            NULL,
            EMPTY
        }
        public InvalidMoodException(ExceptionTypes type, string message) : base(message)
        {
            exceptionTypes = type;
        }
    }
}
