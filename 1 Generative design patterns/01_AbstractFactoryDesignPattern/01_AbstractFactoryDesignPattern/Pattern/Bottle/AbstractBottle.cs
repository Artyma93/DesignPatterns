using _01_AbstractFactoryDesignPattern.Pattern.Water;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01_AbstractFactoryDesignPattern.Pattern.Bottle
{
    abstract class AbstractBottle
    {
        public abstract void Interact(AbstractWater water);
    }
}
