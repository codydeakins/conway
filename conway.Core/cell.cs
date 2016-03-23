using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conway.Core
{
    public enum CellState
    {
        Dead,
        Alive
    }
    public class Cell
    {
        public CellState State { get; set; }

        public char DisplayCharacter
        {
            get
            {
                //if dead
                //   display '.'
                //otherwise
                //  return '#'
                if (State == CellState.Dead)
                {
                    return '.';
                }

                else {
                    return '#';
                }

            }

        }
    }
}

