using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mordecai.Types
{
    public interface IThing
    {
        int Id { get; set; }
        string Description { get; set; }
    }
}
