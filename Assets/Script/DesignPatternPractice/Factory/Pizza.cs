using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.factory
{
    // 베이스
    public abstract class Pizza
    {
        public virtual void OrderComplete()
        {
            Debug.Log("피자 주문 나왔습니다~!");
        }
    }

    // 기본 스타일
    public class DefaultPizza : Pizza
    {
        public override void OrderComplete()
        {
            Debug.Log("피자 주문 나왔습니다~!");
        }
    }

    public class CombinationPizza : Pizza
    {
        public override void OrderComplete()
        {
            Debug.Log("콤비네이션 피자 주문 나왔습니다~!");
        }
    }

    public class BulgogiPizza : Pizza
    {
        public override void OrderComplete()
        {
            Debug.Log("불고기 피자 주문 나왔습니다~!");
        }
    }

    public class PotatoPizza : Pizza
    {
        public override void OrderComplete()
        {
            Debug.Log("포테이토 피자 주문 나왔습니다~!");
        }
    }

    // 뉴욕 스타일
    public class NYPotatoPizza : Pizza // PotatoPizza 상속할지 그냥 Pizza 상속할지는 원하는 설계에 따라.
    {
        public override void OrderComplete()
        {
            Debug.Log("뉴욕 스타일 포테이토 피자 주문 나왔습니다~!");
        }
    }
}