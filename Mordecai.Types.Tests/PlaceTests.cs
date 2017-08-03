using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mordecai.Types.Tests
{
    [TestClass]
    public class PlaceTests
    {
        [TestMethod]
        public void InitializePlace()
        {
            var place = new Place();
            Assert.IsNotNull(place.ThingsPresent);
        }

        [TestMethod]
        public void EnterPlace()
        {
            var place = new Place();
            var thing = new Character();
            thing.Id = 42;
            place.Enter(thing);
            Assert.AreEqual(1, place.ThingsPresent.Count,"count here");
            Assert.AreEqual(42, place.ThingsPresent[0].Id,"Id here");
            Assert.ReferenceEquals(this, thing.Location);
        }
        [TestMethod]
        public void LeavePlace()
        {
            var place = new Place();
            var thing = new Character();
            thing.Id = 42;
            place.Enter(thing);
            place.Leave(thing);
            Assert.AreEqual(0, place.ThingsPresent.Count, "count here");
            Assert.IsNull(thing.Location);
        }
    }
}
