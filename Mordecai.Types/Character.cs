using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mordecai.Types
{
    public class Character : IThing, IContainer
    {
        public List<IItem> Items { get; }        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Place Location { get; set; }
        public string SelfDescription { get; set; }
        public string CharHistory { get; set; }
        public string Race { get; set; }
        public int SkillPoints { get; set; }
        public int MagicPoints { get; set; }
        public void UseExit(Exit exit)
        {
            exit.Enter(this);
        }
        public void RemoveItem(IItem item)
        {
            Items.Remove(item);
            item.Location = null;
        }
        public void AddItem(IItem item)
        {
            Items.Add(item);
            item.Container = this;
            item.SetLocationtoContainer(this);
        }
    }
}
