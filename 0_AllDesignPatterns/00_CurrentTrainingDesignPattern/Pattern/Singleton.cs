using System;
using System.Collections.Generic;
using System.Text;

namespace _00_CurrentTrainingDesignPattern.Pattern
{
    class Singleton
    {
        static Singleton singleton;
        string singletonData = new String("");

        protected Singleton()
        {

        }

        public static Singleton Instance()
        {
            if(singleton == null)
            {
                singleton = new Singleton();
            }

            return singleton;
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
