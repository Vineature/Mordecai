using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mordecai.Types
{
    public class Weapon : IThing
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
