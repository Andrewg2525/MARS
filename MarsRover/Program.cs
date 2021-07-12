using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Command[] commands = { new Command("foo", 0), new Command("bar", 20) };

            string[] names = { "Colton", "Roger" };
            Message newMessage = new Message("CommandMessage", commands);



            Console.WriteLine(names[0][0]);

            Console.WriteLine(commands[0].CommandType);

            Console.WriteLine(commands);
            Console.WriteLine(newMessage.Commands[0].CommandType);

            newMessage.Commands[0].CommandType = "Something";

            Console.WriteLine(newMessage.Commands[0].CommandType);
            Console.WriteLine(commands[0].CommandType);


            //Console.WriteLine("Hello World!");
            //Rover myRover = new Rover(20);
            //Console.WriteLine(myRover.ToString());


        }
    }
}
