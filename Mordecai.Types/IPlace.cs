using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mordecai.Types
{
    public interface IPlace
    {
        int Id { get; set; }
        string ShortDescription { get; set; }
        string Description { get; set; }
        void Leave(IThing thing);
        void Enter(IThing thing);
    }
}
