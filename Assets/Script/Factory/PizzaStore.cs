// [HEAD FIRST DESIGN PATTERNS - 04. FACTORY PATTERN]
// 
// Pizza Store
// Author : Soundpiercer
// soundpiercer@gmail.com
//
// 권장하는 보는 순서
// 1. 일단 뉴욕은 무시
// 2. PizzaType.cs
// 3. PizzaStore.cs
// 4. PizzaFactory.cs
// 5. Pizza.cs
// 6. 뉴욕 관련

using UnityEngine;

namespace headfirst.factory
{
    public class PizzaStore : MonoBehaviour
    {
        protected Pizza pizza;
        protected PizzaFactory pizzaFactory = new PizzaFactory();

        protected void Start()
        {
            OrderPizza(PizzaType.Combination);
            OrderPizza(PizzaType.Bulgogi);
            OrderPizza(PizzaType.Potato);
        }

        /// <summary>
        /// Orders the pizza.
        /// 피자가 어떻게 만들어지는지 상점은 모릅니다. 그냥 피자 팩토리에서 갖고오는 대로 내주는 것.
        /// </summary>
        /// <param name="type">Type.</param>
        protected void OrderPizza(PizzaType type)
        {
            pizza = pizzaFactory.CreatePizza(type); // 피자를 만든다.
            GameObject go = new GameObject(pizza.GetName()); // 피자를 내 온다.

            pizza.OrderComplete(); // 주문 완료
        }
    }
}
