using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.command
{
    public class RemoteController : MonoBehaviour
    {
        private List<ButtonSlot> _slotList = new List<ButtonSlot>();

        private void Start()
        {
            _slotList.Add(new ButtonSlot());
            _slotList.Add(new ButtonSlot());
            _slotList.Add(new ButtonSlot());
            _slotList.Add(new ButtonSlot());
            _slotList.Add(new ButtonSlot());

            Single();
            Macro();
            StackOps();
        }

        private void Single()
        {
            Debug.Log("<color=lime>-SINGLE EXECUTION-------------------------</color>");

            _slotList[0].SetCommand(new Command1(new Effect1()));
            _slotList[1].SetCommand(new Command2(new Effect2()));
            _slotList[2].SetCommand(new Command3(new Effect3()));
            _slotList[3].SetCommand(new Command1(new Effect3()));
            _slotList[4].SetCommand(new NullCommand());

            foreach (ButtonSlot b in _slotList)
            {
                b.Click();
            }
        }

        private void Macro()
        {
            Debug.Log("<color=lime>-MACRO EXECUTION--------------------------</color>");

            _slotList[0].SetCommand(new Macro1(new Effect[] { new Effect3(), new Effect2(), new Effect1()}));

            _slotList[0].Click();
        }

        private void StackOps()
        {
            Debug.Log("<color=lime>-STACK EXECUTION--------------------------</color>");

            _slotList[0].SetCommand(new Command1(new Effect1()));

            Debug.LogWarning("Undo 3 Commands");
            CommandStack.Undo(3);
        }
    }
}