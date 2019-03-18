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
            if (_effect.isOn)
                _effect.Off();
            else
                _effect.On();
        }
    }

    // Null
    // Undo (Queue, Stack)
    // Macro
}