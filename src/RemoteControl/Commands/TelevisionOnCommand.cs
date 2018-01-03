using RemoteControl.Appliances;

namespace RemoteControl.Commands
{
    public class TelevisionOnCommand : ICommand
    {
        private readonly Television _television;

        public TelevisionOnCommand(Television television)
        {
            _television = television;
        }

        public void Excecute()
        {
            _television.On();
        }

        public void Undo()
        {
            _television.Off();
        }
    }
}
