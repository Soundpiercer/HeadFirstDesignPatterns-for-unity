using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.factory
{
    public class NYPizzaStore : PizzaStore
    {
        protected override void Start()
        {
            pizzaFactory = new NYPizzaFactory();
            base.Start();
        }
    }
}