using System;
using System.Collections.Generic;
using System.Text;

namespace _12_ProxyDesignPattern.Pattern
{
    class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("RealSubject");
        }
    }
}
