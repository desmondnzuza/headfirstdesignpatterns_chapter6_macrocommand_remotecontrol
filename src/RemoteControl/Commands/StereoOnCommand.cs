using RemoteControl.Appliances;

namespace RemoteControl.Commands
{
    public class StereoOnCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOnCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Excecute()
        {
            _stereo.On();
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}
