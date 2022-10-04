using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exceptions
{
    public class ExceptionClass : Exception
    {
        public ExceptionClass (){}
        public ExceptionClass (string message) : base(message){}
        public ExceptionClass (string message, Exception inner) : base(message, inner){}

    }
}