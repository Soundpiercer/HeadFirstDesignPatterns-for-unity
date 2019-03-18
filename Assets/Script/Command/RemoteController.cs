﻿using System.Collections;
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

            _slotList[0].SetCommand(new Command1(new Effect1()));
            _slotList[1].SetCommand(new Command2(new Effect2()));
            _slotList[2].SetCommand(new Command3(new Effect3()));
            _slotList[3].SetCommand(new Command1(new Effect3()));
            _slotList[4].SetCommand(new NullCommand());

            Debug.Log("<color=lime>-NORMAL EXECUTION--------------------------</color>");

            foreach (ButtonSlot b in _slotList)
            {
                b.OnButtonClicked();
            }

            Macro();
        }

        private void Macro()
        {
            Debug.Log("<color=lime>-MACRO EXECUTION--------------------------</color>");
        }
    }
}