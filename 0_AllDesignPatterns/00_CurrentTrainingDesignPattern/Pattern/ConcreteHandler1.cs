﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _00_CurrentTrainingDesignPattern.Pattern
{
    class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 1)
            {
                Console.WriteLine("One");
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(request);
            }
        }
    }
}
