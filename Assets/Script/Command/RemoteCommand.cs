namespace headfirst.command
{
    public interface ICommand
    {
        void Execute();
    }

    public class Command1 : ICommand
    {
        Effect _effect;

        public Command1 (Effect effect)
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

    // Undo (Queue, Stack)
    // Macro
}