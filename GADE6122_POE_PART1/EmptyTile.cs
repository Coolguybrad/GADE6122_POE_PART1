using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_PART1
{
    class EmptyTile : Tile //Inherits from Tile class
    {
        //EmptyTile constructor:
        public EmptyTile(int x, int y, TileType t) : base(x, y, t)
        {
        }
    }
}
