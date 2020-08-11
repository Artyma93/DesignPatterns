using _06_AdapterDesignPattern_Object.Pattern;
using System;

namespace _06_AdapterDesignPattern_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();
        }
    }
}
