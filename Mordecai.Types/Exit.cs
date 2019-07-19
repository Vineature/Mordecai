using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mordecai.Types
{
    public class Exit : IThing
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Place Location { get; set; }
        public Place Destination { get; set; }

        public virtual void Enter(IThing thing)
        {
            Location.Leave(thing);
            Destination.Enter(thing);
        }
    }
}
