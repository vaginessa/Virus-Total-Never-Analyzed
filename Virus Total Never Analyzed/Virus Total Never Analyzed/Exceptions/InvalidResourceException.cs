using System;

namespace Virus_Total_Never_Analyzed.Exceptions
{
    public class InvalidResourceException : Exception
    {
        public InvalidResourceException(string message) : base(message) { }
    }
}