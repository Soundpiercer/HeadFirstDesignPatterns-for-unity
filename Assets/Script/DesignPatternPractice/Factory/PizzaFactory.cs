using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.factory
{
    public class PizzaFactory
    {
        // static으로 만들면 팩토리를 인스턴스화하지 않아도 된다.
        // 단, PizzaFactory를 상속하게 될 경우엔 static이면 안되고 스토어에서 따로 객체를 생성해 주어야 한다.
        public virtual Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Combination:
                    return new CombinationPizza();
                case PizzaType.Bulgogi:
                    return new BulgogiPizza();
                case PizzaType.Potato:
                    return new PotatoPizza();
                default:
                    return new DefaultPizza();
            }
        }
    }

    public class NYPizzaFactory : PizzaFactory
    {
        // static으로 만들면 팩토리를 인스턴스화하지 않아도 된다.
        // 단, PizzaFactory를 상속하게 될 경우엔 static이면 안되고 스토어에서 따로 객체를 생성해 주어야 한다.
        public override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Combination:
                    return new CombinationPizza();
                case PizzaType.Bulgogi:
                    return new BulgogiPizza();
                case PizzaType.Potato:
                    return new NYPotatoPizza();
                default:
                    return new DefaultPizza();
            }
        }
    }
}
