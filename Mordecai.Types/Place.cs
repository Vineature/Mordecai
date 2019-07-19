using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mordecai.Types
{
    public class Place : IPlace
    {
        public int Id { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int EncounterChance { get; set; }
        public string StateChange { get; set; }
        public List<Exit> Exits { get; }
        public List<IThing> ThingsPresent { get; private set; }

        public Place()
        {
            ThingsPresent = new List<IThing>();
        }

        public void Leave(IThing thing)
        {
            ThingsPresent.Remove(thing);
            thing.Location = null;
            // TODO: notify other things that this thing left
        }

        public void Enter(IThing thing)
        {
            ThingsPresent.Add(thing);
            thing.Location = this;
            // TODO: notify other things that this thing arrived
        }
    }
}
