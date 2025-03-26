using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TechLibrary.Exception
{
    public class NotFoundException : TechLibraryException
    {
        public NotFoundException(string message) : base(message) { }
        public override List<string> GetErrorMessages() => [Message];

        public override HttpStatusCode GetStatusCode() => HttpStatusCode.NotFound;
    }
}
