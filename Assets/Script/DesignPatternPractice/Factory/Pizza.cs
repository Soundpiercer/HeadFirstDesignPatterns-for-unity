using UnityEngine;

namespace headfirst.factory
{
    // 베이스
    public abstract class Pizza
    {
        public abstract string GetName();

        public virtual void OrderComplete()
        {
            Debug.Log(GetName() + " 주문 나왔습니다~!");
        }
    }

    #region Basic
    public class DefaultPizza : Pizza
    {
        public override string GetName() { return "기본 피자"; }
    }

    public class CombinationPizza : Pizza
    {
        public override string GetName() { return "콤비네이션 피자"; }
    }

    public class BulgogiPizza : Pizza
    {
        public override string GetName() { return "불고기 피자"; }
    }

    public class PotatoPizza : Pizza
    {
        public override string GetName() { return "포테이토 피자"; }
    }
    #endregion

    // 뉴욕 스타일
    public class NewYorkPotatoPizza : Pizza // PotatoPizza 상속할지 그냥 Pizza 상속할지는 설계에 따라 case by case.
    {
        public override string GetName() { return "뉴욕 포테이토 피자"; }
    }
}