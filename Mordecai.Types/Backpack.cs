using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mordecai.Types
{
    public class Backpack : IContainer, IItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Place Location { get; set; }
        public List<IItem> Items { get; }
        public IContainer Container { get; set; }
        public int Weight { get; set; }
        public Backpack()
        {
            Items = new List<IItem>();
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
            item.Location = null;
        }
    }
}
