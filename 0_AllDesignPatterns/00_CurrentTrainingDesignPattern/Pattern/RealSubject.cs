using System;
using System.Collections.Generic;
using System.Text;

namespace _00_CurrentTrainingDesignPattern.Pattern
{
    class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("RealSubject");
        }
    }
}
