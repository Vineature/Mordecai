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
        List<IThing> ThingsPresent { get; }
        List<Exit>  Exits { get; }
        string Description { get; set; }
        void Leave(IThing thing);
        void Enter(IThing thing);
    }
}
