using UnityEngine;

namespace headfirst.strategy
{
    /// <summary>
    /// All MarioFireBehaviour classes must implement Fire(); method.
    /// </summary>
    public interface IMarioFireBehaviour // 접근 권한에 상관없이 어디서든 액세스 가능하도록 인터페이스를 public으로 선언합니다.
    {
        void Fire();
    }

    public class MarioFireBehaviourSmall : IMarioFireBehaviour
    {
        public void Fire()
        {
            return;
        }
    }

    public class MarioFireBehaviourBig : IMarioFireBehaviour
    {
        public void Fire()
        {
            return;
        }
    }

    public class MarioFireBehaviourFlower : IMarioFireBehaviour
    {
        public void Fire()
        {
            Debug.Log("<color=#FF8800>Mario Flower Fire~~~!!!</color>");
        }
    }

    public class MarioFireBehaviourSquarrel : IMarioFireBehaviour
    {
        public void Fire()
        {
            return;
        }
    }
}