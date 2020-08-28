using _12_ProxyDesignPattern.Pattern;
using System;

namespace _12_ProxyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Proxy();
            subject.Request();

        }
    }
}
