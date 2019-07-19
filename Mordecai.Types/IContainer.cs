using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mordecai.Types
{
    public interface IContainer : IThing
    {
        List<IItem> Items { get; }
        void RemoveItem(IItem item);
        void AddItem(IItem item);
    }
}
