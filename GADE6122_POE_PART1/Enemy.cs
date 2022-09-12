using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_PART1
{
    abstract class Enemy : Character //Inherits from Character class
    {
        //Creating a randNum object and setting the variable associated with it to a random number generated within a range:
        Random randNum = new Random();
        private TileType tile;
        
        //Enemy constructor
        public Enemy(int x, int y, TileType t, int damage, int HP, int maxHP) : base(x, y, t)
        {
            tile = t;
        }

        //Overrided ToString() Method:
        public override string ToString()
        {
            return tile + " at [" + x + ", " + y + "] (" + damage + ")";
        }
    }
}
