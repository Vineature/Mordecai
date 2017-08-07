using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mordecai.Types
{
    public class Chest : IContainer
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public IPlace Location { get; set; }
        public IContainer Container { get; set; }
        public List<IItem> Items { get; private set; }
        public Chest()
        {
            Items = new List<IItem>();
        }
        public void RemoveItem(IItem item)
        {
            Items.Remove(item);
            item.Location = null;
        }
        public void AddItem (IItem item)
        {
            Items.Add(item);
            item.Container = this;
        }
    }
}
