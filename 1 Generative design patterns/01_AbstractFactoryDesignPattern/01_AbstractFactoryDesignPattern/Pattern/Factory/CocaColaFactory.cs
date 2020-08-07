using _01_AbstractFactoryDesignPattern.Pattern.Bottle;
using _01_AbstractFactoryDesignPattern.Pattern.Water;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01_AbstractFactoryDesignPattern.Pattern.Factory
{
    class CocaColaFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }

        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }
    }
}
