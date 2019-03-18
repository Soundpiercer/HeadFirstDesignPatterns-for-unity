using UnityEngine;

namespace headfirst.command
{
    public abstract class Effect
    {
        public bool isOn = false;

        public abstract void On();
        public abstract void Off();
    }

    public class Effect1 : Effect
    {
        public override void On()
        {
            Debug.Log("Effect ON");
        }

        public override void Off()
        {
            Debug.Log("Effect OFF");
        }
    }
}