using _10_FacadeDesignPattern.Pattern;
using System;

namespace _10_FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.OperationAB();
            facade.OperationBC();
        }
    }
}
