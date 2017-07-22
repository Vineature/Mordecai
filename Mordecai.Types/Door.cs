using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mordecai.Types
{
    public class Door : Exit
    {
        public bool IsOpen { get; set; }

        public override void Enter(IThing thing)
        {
            if (IsOpen)
            {
                base.Enter(thing);
            }
            else
            {
                // TODO: notify that the door is closed
            }
        }
    }
}
