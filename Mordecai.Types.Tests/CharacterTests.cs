using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mordecai.Types.Tests
{
    [TestClass]
    public class CharacterTests
    {
        [TestMethod]
        public void UseExit()
        {
            var place1 = new Place();
            var place2 = new Place();
            var character = new Character();
            var exit = new Exit();
            exit.Location = place1;
            exit.Destination = place2;
            character.Location = place1;
            Assert.AreNotEqual(character.Location, exit.Destination, "Before exit");
            //string UserInput = Console.
            //if (UserInput == "Exit")
            //{
                character.UseExit(exit);
            //}
            //if (UserInput == "Exit")
            //{
                Assert.AreEqual(character.Location, exit.Destination, "After exit");
            //}
            //else
            //{
              //  Assert.AreNotEqual(character.Location, exit.Destination, "If user did not exit");
            //}
        }
        [TestMethod]
        public void WeaponInBackPackInCharacterAllMoving()
        {
            var place1 = new Place();
            var place2 = new Place();
            var exit = new Exit();
            var character = new Character();
            var backpack = new Backpack();
            var weapon = new Weapon();
            character.Id = 5;
            backpack.Id = 6;
            weapon.Id = 7;
            exit.Location = place1;
            exit.Destination = place2;
            backpack.Location = exit.Location;
            character.Location = exit.Location;
            character.AddItem(backpack);
            backpack.AddItem(weapon);
            character.UseExit(exit);
            Assert.AreEqual(1, character.Items.Count, "count here");
            Assert.AreEqual(6, character.Items[0].Id, "Id here");
            Assert.AreEqual(backpack.Container, character);
            Assert.AreEqual(1, backpack.Items.Count, "count here");
            Assert.AreEqual(7, backpack.Items[0].Id, "Id here");
            Assert.AreEqual(weapon.Container, backpack);
            Assert.AreEqual(character.Location, exit.Destination, "After exit");
            Assert.IsNull(backpack.Location);
            Assert.IsNull(weapon.Location);
        }
    }
}
