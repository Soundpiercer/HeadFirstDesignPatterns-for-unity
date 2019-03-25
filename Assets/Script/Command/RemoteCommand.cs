using System;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.command
{
    public interface ICommand
    {
        void Execute();
    }

    #region Single Command
    public class Command1 : ICommand
    {
        Effect _effect;

        public Command1(Effect effect)
        {
            _effect = effect;
        }

        public void Execute()
        {
            if (_effect.IsOn())
                _effect.Off();
            else
                _effect.On();

            CommandStack.Push(this);
        }
    }

    public class Command2 : ICommand
    {
        Effect _effect;

        public Command2(Effect effect)
        {
            _effect = effect;
        }

        public void Execute()
        {
            if (_effect.IsOn())
                _effect.Off();
            else
                _effect.On();

            CommandStack.Push(this);
        }
    }

    public class Command3 : ICommand
    {
        Effect _effect;

        public Command3(Effect effect)
        {
            _effect = effect;
        }

        public void Execute()
        {
            if (_effect.IsOn())
                _effect.Off();
            else
                _effect.On();

            CommandStack.Push(this);
        }
    }

    /// <summary>
    /// 커맨드를 정의하지 않는 널(더미) 오브젝트입니다.
    /// </summary>
    public class NullCommand : ICommand
    {
        Effect _nullEffect = new NullEffect();

        public void Execute()
        {
            _nullEffect.On();
        }
    }
    #endregion

    public class Macro1 : ICommand
    {
        Queue<Effect> _queue = new Queue<Effect>();

        public Macro1()
        {
            
        }

        public Macro1(Effect[] args)
        {
            foreach (Effect e in args)
            {
                _queue.Enqueue(e);
            }
        }

        public void Execute()
        {
            foreach (Effect e in _queue)
            {
                if (e.IsOn())
                {
                    e.Off();
                }
                else
                {
                    e.On();
                }
            }
        }
    }

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
                    _stack.Pop().Execute();
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