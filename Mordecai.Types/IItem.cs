using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mordecai.Types
{
    public interface IItem : IThing
    {
        int Weight { get; set; }
        IContainer Container { get; set; }
        void SetLocationtoContainer(IContainer container)
    }
}
