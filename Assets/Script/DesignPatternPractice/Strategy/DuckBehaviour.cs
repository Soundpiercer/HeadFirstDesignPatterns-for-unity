using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.strategy
{
    public class ICantFly : IFlyBehaviour
    {
        public void Fly()
        {
            Debug.LogWarning("I Can't Fly!");
        }
    }

    public class ICanFly : IFlyBehaviour
    {
        public void Fly()
        {
            Debug.Log("I Can Fly!");
        }
    }

    public class StrangeQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Debug.LogWarning("Squeak!");
        }
    }

    public class NormalQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Debug.Log("Quack!");
        }
    }

    public class ICantSwim : ISwimBehaviour
    {
        public void Swim()
        {
            Debug.LogWarning("I'm gonna be drowned!");
        }
    }

    public class ICanSwim : ISwimBehaviour
    {
        public void Swim()
        {
            Debug.Log("swimswim~~");
        }
    }
}