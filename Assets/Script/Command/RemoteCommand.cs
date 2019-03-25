using System;
using System.Collections.Generic;
using UnityEngine;

namespace headfirst.command
{
    public interface ICommand
    {
        void Execute();
        void UnExecute();
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
        }

        public void UnExecute()
        {
            Execute();
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
        }

        public void UnExecute()
        {
            Execute();
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
        }

        public void UnExecute()
        {
            Execute();
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

        public void UnExecute()
        {
            Execute();
        }
    }
    #endregion

    public class Macro1 : ICommand
    {
        List<Effect> _effectList = new List<Effect>();

        public Macro1()
        {
            
        }

        public Macro1(Effect[] args)
        {
            foreach (Effect e in args)
            {
                _effectList.Add(e);
            }
        }

        public void Execute()
        {
            for (int i = 0; i < _effectList.Count; i++)
            {
                if (_effectList[i].IsOn())
                {
                    _effectList[i].Off();
                }
                else
                {
                    _effectList[i].On();
                }
            }
        }

        public void UnExecute()
        {
            for (int i = _effectList.Count; i > 0; i--)
            {
                if (_effectList[i - 1].IsOn())
                {
                    _effectList[i - 1].Off();
                }
                else
                {
                    _effectList[i - 1].On();
                }
            }
        }
    }
}