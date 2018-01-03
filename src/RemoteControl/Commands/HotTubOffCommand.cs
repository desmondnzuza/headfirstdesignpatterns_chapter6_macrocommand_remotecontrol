using RemoteControl.Appliances;

namespace RemoteControl.Commands
{
    public class HotTubOffCommand : ICommand
    {
        private readonly HotTub _tub;

        public HotTubOffCommand(HotTub tub)
        {
            _tub = tub;
        }

        public void Excecute()
        {
            _tub.JetsOff();
        }

        public void Undo()
        {
            _tub.JetsOn();
        }
    }
}
