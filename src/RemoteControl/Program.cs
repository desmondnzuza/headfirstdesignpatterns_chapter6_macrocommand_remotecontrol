using System;
using RemoteControl.Appliances;
using RemoteControl.Commands;
using RemoteControl.Controllers;

namespace RemoteControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new Controllers.RemoteControl();

            var livingRoonLight = new Light("Living Room");
            var television = new Television("Living Room");
            var stereo = new Stereo("Living Room");
            var hotTub = new HotTub();

            var lightOn = new LightOnCommand(livingRoonLight);
            var lightOff = new LightOffCommand(livingRoonLight);

            var televisionOn = new TelevisionOnCommand(television);
            var televisionOff = new TelevisionOffCommand(television);

            var stereoOn = new StereoOnCommand(stereo);
            var stereoOff = new StereoOffCommand(stereo);

            var hotTubOn = new HotTubOnCommand(hotTub);
            var hotTubOff = new HotTubOffCommand(hotTub);

            var partyOn = new ICommand[] {lightOn, stereoOn, televisionOn, hotTubOn};
            var partyOff = new ICommand[] { lightOff, stereoOff, televisionOff, hotTubOff };

            var partyMacroOn = new MacroCommand(partyOn);
            var partyMacroOff = new MacroCommand(partyOff);

            remoteControl.SetCommand(0, partyMacroOn, partyMacroOff);

            Console.WriteLine(remoteControl);
            Console.WriteLine("----------Push Macro On----------");
            remoteControl.OnButtonWasPressed(0);
            Console.WriteLine("----------Push Macro Off---------");
            remoteControl.OffButtonWasPressed(0);

            Console.ReadLine();
        }
    }
}
