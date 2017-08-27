using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mordecai.Types.Tests
{
    [TestClass]
    public class ExitTests
    {
        [TestMethod]
        public void ExitPlace()
        {
            var place1 = new Place();
            var place2 = new Place();
            var exit = new Exit();
            var character = new Character();
            exit.Location = place1;
            exit.Destination = place2;
            character.Location = exit.Location;
            exit.Enter(character);
            Assert.AreEqual(exit.Destination, character.Location);
        }
        [TestMethod]
        public void ExitPlaceBackward()
        {
            var place1 = new Place();
            var place2 = new Place();
            var exit = new Exit();
            var character = new Character();
            exit.Location = place2;
            exit.Destination = place1;
            character.Location = place1;
            var FirstPlace = new Place();
            FirstPlace = character.Location;
            exit.Enter(character);
            Assert.AreEqual(FirstPlace, character.Location);
        }
        [TestMethod]
        public void TwoWayExitOneEnter()
        {
            var place1 = new Place();
            var place2 = new Place();
            var exit = new TwoWayExit();
            var character = new Character();
            exit.Location = place1;
            exit.Location2 = place2;
            character.Location = place1;
            exit.GetDestination(character);
            Assert.AreEqual(character.Location, exit.CurrentLocation, "character and exit location are equal");
            exit.Enter(character);
            Assert.AreEqual(character.Location, exit.Destination, "character and exit destination are equal");
        }
        [TestMethod]
        public void TwoWayExitTwoEnter()
        {
            var place1 = new Place();
            var place2 = new Place();
            var exit = new TwoWayExit();
            var character = new Character();
            exit.Location = place1;
            exit.Location2 = place2;
            character.Location = place1;
            exit.GetDestination(character);
            Assert.AreEqual(character.Location, exit.CurrentLocation, "character and exit location are equal");
            exit.Enter(character);
            Assert.AreEqual(character.Location, exit.Destination, "character and exit destination are equal");
            exit.GetDestination(character);
            Assert.AreEqual(character.Location, exit.CurrentLocation, "character and exit location are equal");
            exit.Enter(character);
            Assert.AreEqual(character.Location, exit.Destination, "character and exit destination are equal");
        }
    }
}
