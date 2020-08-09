using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02_Builder.HouseElement
{
    class House
    {
        ArrayList parts = new ArrayList();

        public void Add(object part)
        {
            parts.Add(part);
        }
    }
}
