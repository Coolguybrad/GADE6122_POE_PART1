using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_POE_PART1
{
    internal class SwampCreature : Enemy //Inherits from Enemy class
    {

        //Constructor for the swamp creatures, with the necassary parameters:
        public SwampCreature(int x, int y, TileType t, int d, int hp, int mHP) : base(x, y, t, d, hp, mHP)
        {
            this.damage = 1;
            this.hp = 10;
            this.maxHP = 10;
        }

        public override Movement ReturnMove(Movement m = 0) //Overrided ReturnMove
        {
            Movement[] validM = new Movement[4]; //Array of valid movements
            int count = 0; //counter for validM array

            //if the tiles directly above, below, to the left and to the right of the
            //creature are neither a hero nor a wall(no wall yet) movement type is added
            //to valid movement array and count incrimented by 1
            if (playerVision[0].getType() != TileType.Hero || (playerVision[0] is Obstacle))//Will de Morgan mess us UP??????
            {
                validM[count] = Movement.Up;
                count++;
            }
            else if (playerVision[1].getType() != TileType.Hero || (playerVision[0] is Obstacle))//Will de Morgan mess us UP??????
            {
                validM[count] = Movement.Down;
                count++;
            }
            else if (playerVision[2].getType() != TileType.Hero || (playerVision[0] is Obstacle))//Will de Morgan mess us UP??????
            {
                validM[count] = Movement.Left;
                count++;
            }
            else if (playerVision[3].getType() != TileType.Hero || (playerVision[0] is Obstacle))//Will de Morgan mess us UP??????
            {
                validM[count] = Movement.Right;
                count++;
            }

            //random number generated to determine the direction the creature will move
            Random randNum = new Random();
            int num = randNum.Next(0, count);
            Movement move = validM[num];

            return move; //returns move
        }
    }
}
