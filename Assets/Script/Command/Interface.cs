using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.command
{
    public interface ICommand
    {
        void Execute();
    }

    public class LightOnCommand : ICommand
    {
        Light _light;

        public LightOnCommand (Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }
    }

    public class Light
    {
        public void On()
        {
            Debug.Log("On");
        }
    }

    public class SimpleRemoteControl
    {
        ICommand _slot;

        public void SetCommand(ICommand command)
        {
            _slot = command;
        }

        public void OnButtonClicked()
        {
            _slot.Execute();
        }
    }

    public class RemoteControl : MonoBehaviour
    {
        SimpleRemoteControl remote = new SimpleRemoteControl();
        Light _light = new Light();
        LightOnCommand _lightOn;

        private void Start()
        {
            _lightOn = new LightOnCommand(_light);

            remote.SetCommand(_lightOn);
            remote.OnButtonClicked();
        }
    }

    // Null
    // Undo (Queue, Stack)
    // Macro
}