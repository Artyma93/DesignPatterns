using _06_AdapterDesignPattern_Class.Pattern;
using System;

namespace _06_AdapterDesignPattern_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new Adapter();
            target.Request();
        }
    }
}
