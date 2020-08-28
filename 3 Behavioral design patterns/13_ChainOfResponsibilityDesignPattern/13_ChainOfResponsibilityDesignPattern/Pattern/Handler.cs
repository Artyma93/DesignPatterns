using System;
using System.Collections.Generic;
using System.Text;

namespace _13_ChainOfResponsibilityDesignPattern.Pattern
{
    abstract class Handler
    {
        public Handler Successor { get; set; }

        public abstract void HandleRequest(int request);
    }
}
