using System;
using System.Collections.Generic;
using System.Text;

namespace _12_ProxyDesignPattern.Pattern
{
    class Proxy : Subject
    {
        RealSubject realSubject;

        public override void Request()
        {
            if(realSubject == null)
            {
                realSubject = new RealSubject();
            }

            realSubject.Request();
        }
    }
}
