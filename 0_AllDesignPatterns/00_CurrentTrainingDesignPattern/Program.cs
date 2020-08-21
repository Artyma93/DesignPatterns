
using _00_CurrentTrainingDesignPattern.Pattern;
using System;

namespace _00_CurrentTrainingDesignPattern
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
