using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mordecai.Types.Tests
{
    [TestClass]
    public class ContainerTests
    {
        [TestMethod]
        public void InitializeChest()
        {
            var chest = new Chest();
            Assert.IsNotNull(chest.Items);
        }
        [TestMethod]
        public void AddItemToChest()
        {
            var chest = new Chest();
            var item = new Weapon();
            item.Id = 42;
            chest.AddItem(item);
            Assert.AreEqual(1, chest.Items.Count, "count here");
            Assert.AreEqual(42, chest.Items[0].Id, "Id here");
            Assert.AreEqual(item.Container, chest);
        }
        [TestMethod]
        public void RemoveItemFromChest()
        {
            var chest = new Chest();
            var item = new Weapon();
            item.Id = 42;
            chest.AddItem(item);
            chest.RemoveItem(item);
            Assert.AreEqual(0, chest.Items.Count, "count here");
        }
        [TestMethod]
        public void AddBackpackToBackpack()
        {
            var backpack = new Backpack();
            var backpack2 = new Backpack();
            backpack2.Id = 42;
            backpack.AddItem(backpack2);
            Assert.AreEqual(1, backpack.Items.Count, "count here");
            Assert.AreEqual(42, backpack.Items[0].Id, "Id here");
            Assert.AreEqual(backpack2.Container, backpack);
        }
    }
}
