using System;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.command
{
    public static class CommandStack
    {
        private static Stack<ICommand> _stack = new Stack<ICommand>();

        public static void Push(ICommand c)
        {
            _stack.Push(c);
        }

        public static void Undo(int count)
        {
            for (int i = 0; i < count; i++)
            {
                try
                {
                    _stack.Pop().UnExecute();
                }
                catch (Exception)
                {
                    Debug.LogError("Stack is Empty!");
                    break;
                }
            }
        }
    }
}