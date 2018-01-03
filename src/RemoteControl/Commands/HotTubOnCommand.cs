using RemoteControl.Appliances;

namespace RemoteControl.Commands
{
    public class HotTubOnCommand : ICommand
    {
        private readonly HotTub _tub;

        public HotTubOnCommand(HotTub tub)
        {
            _tub = tub;
        }

        public void Excecute()
        {
            _tub.JetsOn();
        }

        public void Undo()
        {
            _tub.JetsOff();
        }
    }
}
