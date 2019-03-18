using UnityEngine;

namespace headfirst.command
{
    public abstract class Effect
    {
        public abstract bool IsOn();

        public abstract void On();
        public abstract void Off();
    }

    public class Effect1 : Effect
    {
        private static bool toggle;

        public override bool IsOn()
        {
            return toggle;
        }

        public override void On()
        {
            Debug.Log("Effect 1 ON");
            toggle = true;
        }

        public override void Off()
        {
            Debug.Log("Effect 1 OFF");
            toggle = false;
        }
    }

    public class Effect2 : Effect
    {
        private static bool toggle;

        public override bool IsOn()
        {
            return toggle;
        }

        public override void On()
        {
            Debug.Log("Effect 2 ON");
            toggle = true;
        }

        public override void Off()
        {
            Debug.Log("Effect 2 OFF");
            toggle = false;
        }
    }

    public class Effect3 : Effect
    {
        private static bool toggle;

        public override bool IsOn()
        {
            return toggle;
        }

        public override void On()
        {
            Debug.Log("Effect 3 ON");
            toggle = true;
        }

        public override void Off()
        {
            Debug.Log("Effect 3 OFF");
            toggle = false;
        }
    }

    /// <summary>
    /// 널(더미) 오브젝트입니다.
    /// </summary>
    public class NullEffect : Effect
    {
        public override bool IsOn()
        {
            return false;
        }

        public override void On()
        {
            Debug.LogWarning("null effect");
        }

        public override void Off()
        {
            Debug.LogWarning("null effect");
        }
    }
}