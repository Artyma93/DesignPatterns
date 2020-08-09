using _01_AbstractFactory.Pattern.Bottle;
using _01_AbstractFactory.Pattern.Factory;
using _01_AbstractFactory.Pattern.Water;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01_AbstractFactory.Pattern
{
    class Client
    {
        AbstractWater water;
        AbstractBottle bottle;

        public Client(AbstractFactory factory)
        {
            this.water = factory.CreateWater();
            this.bottle = factory.CreateBottle();
        }

        public void Run()
        {
            bottle.Interact(water);
        }
    }
}
