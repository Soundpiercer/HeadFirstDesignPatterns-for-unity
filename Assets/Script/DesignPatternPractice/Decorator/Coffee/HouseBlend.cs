using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.decorator
{
    public class HouseBlend : Drink
    {
        public HouseBlend()
        {
            description = "하우스 블렌드 커피";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}