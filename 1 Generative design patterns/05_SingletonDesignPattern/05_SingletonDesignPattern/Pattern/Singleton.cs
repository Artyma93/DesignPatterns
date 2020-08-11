using System;
using System.Collections.Generic;
using System.Text;

namespace _05_SingletonDesignPattern.Pattern
{
    class Singleton
    {
        static Singleton uniqueSingleton;
        string singletonData;

        protected Singleton()
        {

        }

        public static Singleton Initial()
        {
            if(uniqueSingleton == null)
            {
                uniqueSingleton = new Singleton();
            }

            return uniqueSingleton;
        }

        public void SingletonDataOperation()
        {
            singletonData = "SingletonData";
        }

        public string GetSingletonData()
        {
            return singletonData;
        }
    }
}
