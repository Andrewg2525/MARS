using System;
namespace MarsRover
{
    public class Message
    {
        public string Name { get; set; }
        public Command[] Commands { get; set; }

        // Command[] commands = { new Command("MODE_CHANGE", "LOW POWER"), new Command("MOVE", 500) };

        public Message(string name, Command[] commands)
        {
            Name = name;
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(name, "name required.");
            }
            Commands = commands;
        }
    }
}
