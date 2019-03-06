using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.strategy
{
    public class MyDuck : DuckBase
    {
        // 넌 할수있어! 날수있어! 울수있어! 헤엄칠수있어!
        protected override void Start()
        {
            base.Start();
            PrintAction();

            Debug.Log("난 할 수 있어!");

            flyBehaviour = new ICanFly();
            quackBehaviour = new NormalQuack();
            swimBehaviour = new ICanSwim();

            PrintAction();

            Debug.Log("난 해냈어!");
        }
    }
}