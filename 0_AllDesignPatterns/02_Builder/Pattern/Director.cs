using _02_Builder.Pattern.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Builder.Pattern
{
    class Director
    {
        private readonly AbstractBuilder builder;

        public Director(AbstractBuilder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.BuildBasement();
            builder.BuildStorey();
            builder.BuildRoof();
        }
    }
}
