using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.decorator
{
    public class MochaTopping : ToppingDrink
    {
        Drink drink;

        public MochaTopping(Drink drink)
        {
            this.drink = drink;
        }

        public override string GetDescription()
        {
            return drink.GetDescription() + ", 모카";
        }

        public override double Cost()
        {
            return .20 + drink.Cost();
        }
    }
}