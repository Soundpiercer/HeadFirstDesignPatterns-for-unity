using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.command
{
    public class RemoteController : MonoBehaviour
    {
        private ButtonSlot _slot = new ButtonSlot();
        private List<Effect> _effectList = new List<Effect>();
        Command1 _command1;

        private void Start()
        {
            _effectList.Add(new Effect1());
            _command1 = new Command1(_effectList[0]);

            _slot.SetCommand(_command1);
            _slot.OnButtonClicked();
        }
    }
}