using System;
using System.Collections.Generic;
using System.Text;

namespace _00_CurrentTrainingDesignPattern.Pattern
{
    abstract class Handler
    {
        public Handler Successor { get; set; }

        public abstract void HandleRequest(int request);
    }
}
