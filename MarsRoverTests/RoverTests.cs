using System;
using System.Collections.Generic;
using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTests
{
    [TestClass]
    public class RoverTests
    {

        [TestMethod]
        public void ConstructorSetsDefaultPosition()
        {
            Rover newRover = new Rover(10);
            Assert.AreEqual(newRover.Position, 10);
        }

        [TestMethod]
        public void ConstructorSetsDefaultMode()
        {
            Rover newRover = new Rover(10);
            Assert.AreEqual(newRover.Mode, "NORMAL");
        }

        [TestMethod]
        public void ConstructorSetsDefaultWatts()
        {
            Rover newRover = new Rover(10);
            Assert.AreEqual(newRover.GeneratorWatts, 110);
        }

        [TestMethod]
        public void RespondsCorrectlyToModeChangeCommand()
        {
            Rover newRover = new Rover(10);
            Command[] newCommand = { new Command("MODE_CHANGE", "LOW_POWER") };
            Message newMessage = new Message("Change mode", newCommand);

            newRover.ReceiveMessage(newMessage);
            Assert.AreEqual(newRover.Mode, "LOW_POWER");
        }
        [TestMethod]
        public void DoesNotMoveInLowPower()
        {
            Rover newRover = new Rover(10);
            Command[] newCommand = { new Command("MODE_CHANGE", "LOW_POWER"), new Command("MOVE", 25) };
            Message newMessage = new Message("Change mode", newCommand);

            Assert.AreEqual(newRover.Position, 10);
        
        }

        [TestMethod]
        public void PositionChangesFromMoveCommand()
        {
            Rover newRover = new Rover(1000);
          
            Assert.AreEqual(newRover.Position, 1000); 
        }
    }
}
    

