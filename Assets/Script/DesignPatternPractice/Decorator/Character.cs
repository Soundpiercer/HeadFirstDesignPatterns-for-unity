using UnityEngine;

namespace headfirst.decorator
{
    // 추상 클래스란 미완성된 클래스를 말하며,
    // 몸통이 없는 부분 (추상 메서드) 가 하나라도 있으면 추상 클래스가 됩니다.
    public abstract class Character
    {
        public float _basePower = 100f;
        public string _name = "";

        public abstract float GetPower();

        public void ShowInfo()
        {
            Debug.Log("용사 이름 : " + _name + "   전투력 : " + (int)GetPower());
        }
    }

    public class V : Character
    {
        public V()
        {
            _name = "V";
        }

        public override float GetPower()
        {
            return _basePower;
        }
    }

    public class Monte : Character
    {
        public Monte()
        {
            _name = "몽테";
        }

        public override float GetPower()
        {
            return _basePower;
        }
    }

    public class Spiny : Character
    {
        public Spiny()
        {
            _name = "스파이니";
        }

        public override float GetPower()
        {
            return _basePower;
        }
    }
}