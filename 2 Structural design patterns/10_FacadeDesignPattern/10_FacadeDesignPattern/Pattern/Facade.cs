using System;
using System.Collections.Generic;
using System.Text;

namespace _10_FacadeDesignPattern.Pattern
{
    class Facade
    {
        SubSystemA subSystemA = new SubSystemA();
        SubSystemB subSystemB = new SubSystemB();
        SubSystemC subSystemC = new SubSystemC();

        public void OperationAB()
        {
            subSystemA.OperationA();
            subSystemB.OperationB();
        }

        public void OperationBC()
        {
            subSystemB.OperationB();
            subSystemC.OperationC();
        }
    }
}
