using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_PART1
{
    abstract class Enemy : Character
    {
        Random randNum = new Random();
        private TileType tile;
        public Enemy(int x, int y, TileType t, int damage, int HP, int maxHP) : base(x, y, t)
        {
            tile = t;
        }

        public override string ToString()
        {
            return tile + " at [" + x + ", " + y + "] (" + damage + ")";
        }
    }
}
