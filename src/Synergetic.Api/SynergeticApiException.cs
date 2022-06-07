namespace Synergetic.Api
{
    using System;

    internal class SynergeticApiException : Exception
    {
        public SynergeticApiException(string message) : base(message)
        {
        }
    }
}