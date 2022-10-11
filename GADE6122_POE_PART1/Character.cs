using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_PART1
{
    abstract class Character : Tile //Inherits from Tile class
    {
        //Protected member variables:

        protected int hp;
        protected int maxHP;
        protected int damage;
        protected Tile[] playerVision = new Tile[4]; //0 = up. 1 = down. 2 = left. 3 = right.

        //Movement enum:

        public enum Movement
        {
            Stationary,
            Up,
            Down,
            Left,
            Right
        }

        //Constructor:

        public Character(int x, int y, TileType t) : base(x, y, t)
        {

        }

        //Accessors and mutators for the above variables:

        public Tile[] getPlayerVision() 
        {
            return playerVision;
        }

        public void setPlayerVision(Tile u, Tile d, Tile l, Tile r) 
        {
            playerVision[0] = u;
            playerVision[1] = d;
            playerVision[2] = l;
            playerVision[3] = r;
        }
        public int getHP()
        {
            return hp;
        }

        public void setHP(int h)
        {
            hp = h;
        }

        public int getMaxHP()
        {
            return maxHP;
        }

        public void setMaxHP(int h)
        {
            maxHP = h;
        }

        public int getDamage()
        {
            return damage;
        }

        public void setDamage(int d)
        {
            damage = d;
        }

        

        public void setPlayerVision(Tile[] v)
        {
            playerVision = v;
        }

        public virtual void Attack(Character target) //Setting the target's HP after the damage has been applied to the taarget.
        {
            int hp = (target.getHP() - this.getDamage());
            target.setHP(hp);
        }

        //Determining whether or not something is dead (Can be used for enemies or hero):
        public bool isDead()
        {
            bool r;
            if (this.getHP() <= 0)
            {
                r = true;
            }
            else
            {
                r = false;
            }
            return r;
        }

        //Checks if the hero can attack a target by returning true or false:
        public virtual bool CheckRange(Character target)
        {
            int r = 1; //Default barehanded range is 1.
            bool result = false;

            if (DistanceTo(target) <= r)
            {
                result = true;
            }

            return result;
        }

        //Determining the total distance between the character and the target which is parsed into the method:
        public int DistanceTo(Character target)
        {
            int dX = target.getX() - this.getX();
            int dY = target.getY() - this.getY();
            if (dX < 0)
            {
                dX *= -1;
            }
            if (dY < 0)
            {
                dY *= -1;
            }
            int tD = dX + dY;
            return tD;
        }

        //Setting the movement of a target by changing the coordinates of the target:
        public void Move(Movement m)
        {
            int x = this.getX();
            int y = this.getY();
            if (m == Movement.Left)
            {
                this.setX(x - 1);
            }
            else if (m == Movement.Right)
            {
                this.setX(x + 1);
            }
            else if (m == Movement.Up)
            {
                this.setY(y - 1);
            }
            else if (m == Movement.Down)
            {
                this.setY(y + 1);
            }
        }

        //Abstract method:
        public abstract Movement ReturnMove(Movement m = 0);

        //Abstract ToString() method:
        public abstract string ToString();
    }
}
