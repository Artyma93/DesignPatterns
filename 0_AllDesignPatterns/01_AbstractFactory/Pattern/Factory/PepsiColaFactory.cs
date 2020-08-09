using _01_AbstractFactory.Pattern.Bottle;
using _01_AbstractFactory.Pattern.Water;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01_AbstractFactory.Pattern.Factory
{
    class PepsiColaFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new PepsiColaBottle();
        }

        public override AbstractWater CreateWater()
        {
            return new PepsiColaWater();
        }
    }
}
