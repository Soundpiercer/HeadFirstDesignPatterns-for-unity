// [HEAD FIRST DESIGN PATTERNS - 06. COMMAND PATTERN]
// 
// Remote Controller
// Author : Soundpiercer
// soundpiercer@gmail.com
//
// 권장하는 보는 순서
// --------------- Single
// 1. RemoteController.cs
// 2. RemoteButtonSlot.cs
// 3. RemoteCommand.cs (Single Command 부분)
// 4. RemoteCommandEffect.cs
// --------------- Macro
// 5. RemoteController.cs
// 6. RemoteCommand.cs (Macro 부분)
// --------------- Stack Ops
// 7. RemoteController.cs
// 8. RemoteCommandStack.cs

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

            _slotList[0].SetCommand(new Macro1(new Effect[] { new Effect2(), new Effect1(), new Effect1()}));

            _slotList[0].Click();
        }

        private void StackOps()
        {
            Debug.Log("<color=lime>-STACK EXECUTION--------------------------</color>");

            _slotList[0].SetCommand(new Command1(new Effect1()));

            Debug.LogWarning("Undo 7 Commands");
            CommandStack.Undo(7);
        }
    }
}