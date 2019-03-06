using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.decorator
{
    public class Espresso : Drink
    {
        public Espresso()
        {
            description = "에스프레소";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}