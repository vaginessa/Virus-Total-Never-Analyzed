using System;

namespace Virus_Total_Never_Analyzed.Exceptions
{
    /// <summary>
    /// Exception that is thrown when the rate limit has been hit.
    /// </summary>
    public class RateLimitException : Exception
    {
        public RateLimitException(string message)
            : base(message)
        {
        }
    }
}
