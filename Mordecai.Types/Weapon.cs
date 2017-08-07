using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mordecai.Types
{
    public class Weapon : IItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public IPlace Location { get; set; }
        public IContainer Container { get; set; }
    }
}
