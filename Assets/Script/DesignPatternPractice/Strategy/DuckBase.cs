using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.strategy
{
    public class DuckBase : MonoBehaviour
    {
        protected IFlyBehaviour flyBehaviour;
        protected IQuackBehaviour quackBehaviour;
        protected ISwimBehaviour swimBehaviour;

        // 처음엔 날지도 울지도 못하는 오리...
        protected virtual void Start()
        {
            flyBehaviour = new ICantFly();
            quackBehaviour = new StrangeQuack();
            swimBehaviour = new ICantSwim();
        }

        protected virtual void PrintAction()
        {
            flyBehaviour.Fly();
            quackBehaviour.Quack();
            swimBehaviour.Swim();
        }
    }
}