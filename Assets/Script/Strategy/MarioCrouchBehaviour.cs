using UnityEngine;

namespace headfirst.strategy
{
    /// <summary>
    /// All MarioCrouchBehaviour classes must implement Crouch(); method.
    /// </summary>
    public interface IMarioCrouchBehaviour // 접근 권한에 상관없이 어디서든 액세스 가능하도록 인터페이스를 public으로 선언합니다.
    {
        void Crouch();
    }

    public class MarioCrouchBehaviourSmall : IMarioCrouchBehaviour
    {
        public void Crouch()
        {
            return;
        }
    }

    public class MarioCrouchBehaviourBig : IMarioCrouchBehaviour
    {
        public void Crouch()
        {
            Debug.Log("<color=#666666>Mario Crouch.</color>");
        }
    }

    public class MarioCrouchBehaviourFlower : IMarioCrouchBehaviour
    {
        public void Crouch()
        {
            Debug.Log("<color=#666666>Mario Crouch.</color>");
        }
    }

    public class MarioCrouchBehaviourSquarrel : IMarioCrouchBehaviour
    {
        public void Crouch()
        {
            Debug.Log("<color=#666666>Mario Crouch.</color>");
        }
    }
}