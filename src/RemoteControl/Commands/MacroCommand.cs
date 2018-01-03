using System;

namespace RemoteControl.Commands
{
    public class MacroCommand : ICommand
    {
        private readonly ICommand[] _commands;

        public MacroCommand(ICommand[] commands)
        {
            _commands = commands;
        }

        public void Excecute()
        {
            foreach (var command in _commands)
            {
                command.Excecute();
            }
        }

        public void Undo()
        {
            throw new NotSupportedException();
        }
    }
}
