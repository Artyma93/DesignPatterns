using _01_AbstractFactoryDesignPattern.Pattern.Bottle;
using _01_AbstractFactoryDesignPattern.Pattern.Factory;
using _01_AbstractFactoryDesignPattern.Pattern.Water;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01_AbstractFactoryDesignPattern.Pattern
{
    class Client
    {
        private readonly AbstractWater water;
        private readonly AbstractBottle bottle;

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
