using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.decorator
{
    public abstract class ToppingDrink : Drink
    {
        public abstract string GetDescription();
    }
}