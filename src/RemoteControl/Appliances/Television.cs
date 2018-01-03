using System;

namespace RemoteControl.Appliances
{
    public class Television
    {
        private readonly string _area;

        public Television(string area)
        {
            _area = area;
        }

        public void On()
        {
            Console.WriteLine($"{_area} TV is on");
        }

        public void Off()
        {
            Console.WriteLine($"{_area} TV is off");
        }

        public void SetInputChannel(string newChannnel)
        {
            Console.WriteLine($"{_area} TV changing channel to {newChannnel}");
        }

        public void SetVolume(int newVolume)
        {
            Console.WriteLine($"{_area} TV setting volume to {newVolume}");
        }
    }
}
