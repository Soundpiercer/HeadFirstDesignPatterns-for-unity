namespace headfirst.command
{
    public class ButtonSlot
    {
        ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void OnButtonClicked()
        {
            _command.Execute();
        }
    }
}