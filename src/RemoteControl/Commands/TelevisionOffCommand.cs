using RemoteControl.Appliances;

namespace RemoteControl.Commands
{
    public class TelevisionOffCommand : ICommand
    {
        private readonly Television _television;

        public TelevisionOffCommand(Television television)
        {
            _television = television;
        }

        public void Excecute()
        {
            _television.Off();
        }

        public void Undo()
        {
            _television.On();
        }
    }
}
