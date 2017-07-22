using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mordecai.Types
{
    public class Character : IThing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IPlace Location { get; set; }
        public IContainer Container { get; set; }
        public string SelfDescription { get; set; }
        public string CharHistory { get; set; }
        public string Race { get; set; }
        public int SkillPoints { get; set; }
        public int MagicPoints { get; set; }
    }
}
