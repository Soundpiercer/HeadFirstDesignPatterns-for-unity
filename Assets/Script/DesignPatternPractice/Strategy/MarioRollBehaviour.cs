using UnityEngine;

namespace headfirst.strategy
{
    /// <summary>
    /// All MarioRollBehaviour classes must implement Roll(); method.
    /// </summary>
    public interface IMarioRollBehaviour // 접근 권한에 상관없이 어디서든 액세스 가능하도록 인터페이스를 public으로 선언합니다.
    {
        void Roll();
    }

    public class MarioRollBehaviourSmall : IMarioRollBehaviour
    {
        public void Roll()
        {
            return;
        }
    }

    public class MarioRollBehaviourBig : IMarioRollBehaviour
    {
        public void Roll()
        {
            return;
        }
    }

    public class MarioRollBehaviourFlower : IMarioRollBehaviour
    {
        public void Roll()
        {
            return;
        }
    }

    public class MarioRollBehaviourSquarrel : IMarioRollBehaviour
    {
        public void Roll()
        {
            Debug.Log("<color=#AA5500>Mario Squarrel Roll~~~@@@</color>");
        }
    }
}