using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conway.Core
{public enum CellState
    {
        Dead,
        Alive
    }
    class Cell
    {
        public CellState State { get; set; }
    }
}
