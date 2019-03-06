using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.factory
{
    public class PizzaStore : MonoBehaviour
    {
        protected Pizza pizza;
        protected PizzaFactory pizzaFactory = new PizzaFactory();

        // 피자가 어떻게 만들어지는지는 모른다. 그냥 피자 팩토리에서 갖고오는 대로 갖다주는것.
        protected virtual void Start()
        {
            OrderPizza(PizzaType.Combination);
            OrderPizza(PizzaType.Bulgogi);
            OrderPizza(PizzaType.Potato);
        }

        // 상속 등으로 바뀔 필요가 없는 부분.
        protected void OrderPizza(PizzaType type)
        {
            pizza = pizzaFactory.CreatePizza(type);
            pizza.OrderComplete();
        }
    }

}
