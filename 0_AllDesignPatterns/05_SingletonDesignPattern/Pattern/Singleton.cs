using System;
using System.Collections.Generic;
using System.Text;

namespace _05_SingletonDesignPattern.Pattern
{
    class Singleton
    {
        static Singleton uniqueInstance;
        string singletonData = string.Empty;

        protected Singleton()
        {

        }

        public static Singleton Instance()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance = new Singleton();
            }

            return uniqueInstance;
        }

        public void SingletonOperation()
        {
            singletonData = "SingletonData";
        }

        public string GetSingletonData()
        {
            return singletonData;
        }
    }
}
