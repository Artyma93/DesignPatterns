using System;
using System.Collections.Generic;
using System.Text;

namespace _11_FlyweightDesignPattern.Pattern
{
   abstract class Flyweight
    {
        public abstract void Operation(ConsoleColor extrinsicState);
    }
}
