using System;

namespace Premium.Commons.Types
{    
    public class PremiumException : Exception
    {
        public string Code { get; }

        public PremiumException()
        {
        }

        public PremiumException(string code)
        {
            Code = code;
        }

        public PremiumException(string message, params object[] args)
            : this(string.Empty, message, args)
        {
        }

        public PremiumException(string code, string message, params object[] args)
            : this(null, code, message, args)
        {
        }

        public PremiumException(Exception innerException, string message, params object[] args)
            : this(innerException, string.Empty, message, args)
        {
        }

        public PremiumException(Exception innerException, string code, string message, params object[] args)
            : base(string.Format(message, args), innerException)
        {
            Code = code;
        }
    }
}