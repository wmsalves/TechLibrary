﻿using System.Net;

namespace TechLibrary.Exception
{
    public abstract class TechLibraryException : System.Exception
    {
        public TechLibraryException(string message) : base(message) { }
        public abstract List<string> GetErrorMessages();
        public abstract HttpStatusCode GetStatusCode();
    }
}
