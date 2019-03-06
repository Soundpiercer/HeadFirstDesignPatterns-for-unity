using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.decorator
{
    public abstract class Drink
    {
        public string description = "";

        public string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}