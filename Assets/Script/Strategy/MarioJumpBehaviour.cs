using UnityEngine;

namespace headfirst.strategy
{
    /// <summary>
    /// All MarioJumpBehaviour classes must implement Jump(); method.
    /// </summary>
    public interface IMarioJumpBehaviour // 접근 권한에 상관없이 어디서든 액세스 가능하도록 인터페이스를 public으로 선언합니다.
    {
        void Jump();
    }

    public class MarioJumpBehaviourSmall : IMarioJumpBehaviour
    {
        public void Jump()
        {
            Debug.Log("<color=#DDDDDD>Mario Jump</color>");
        }
    }

    public class MarioJumpBehaviourBig : IMarioJumpBehaviour
    {
        public void Jump()
        {
            Debug.Log("<color=#DDDDDD>Mario High Jump~!!!</color>");
        }
    }

    public class MarioJumpBehaviourFlower : IMarioJumpBehaviour
    {
        public void Jump()
        {
            Debug.Log("<color=#DDDDDD>Mario High Jump~!!!</color>");
        }
    }

    public class MarioJumpBehaviourSquarrel : IMarioJumpBehaviour
    {
        public void Jump()
        {
            Debug.Log("<color=#DDDDDD>Mario High Jump~!!!</color>");
        }
    }
}