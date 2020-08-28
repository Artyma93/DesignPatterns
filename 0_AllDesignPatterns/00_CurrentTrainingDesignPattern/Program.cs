
using _00_CurrentTrainingDesignPattern.Pattern;
using System;

namespace _00_CurrentTrainingDesignPattern
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
