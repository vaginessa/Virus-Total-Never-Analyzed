using System;

namespace Virus_Total_Never_Analyzed.Exceptions
{
    /// <summary>
    /// Exception that is thrown when the file size exceeds the allowed.
    /// </summary>
    public class SizeLimitException : Exception
    {
        public SizeLimitException(string message)
            : base(message)
        {
        }
    }
}
