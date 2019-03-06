using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.strategy
{
    public interface IFlyBehaviour
    {
        void Fly();
    }

    public interface IQuackBehaviour
    {
        void Quack();
    }

    public interface ISwimBehaviour
    {
        void Swim();
    }
}