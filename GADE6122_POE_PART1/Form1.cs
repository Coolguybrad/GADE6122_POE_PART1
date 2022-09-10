using System;
using System.Windows.Forms;

namespace GADE6122_POE_PART1
{
    public partial class Form1 : Form
    {
        GameEngine gameEngine = new GameEngine();

        public Form1()
        {
            InitializeComponent();

            Console.WriteLine("Hello");

            

            DisplayMap();

        }

        public void DisplayMap()
        {
            lblMap.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericMonospace.ToString(), 10);
            lblMap.Text = gameEngine.ToString();
        }

        public void FillComboBox()
        {
            for (int i = 0; i < gameEngine.getMap().getEnemy().Length; i++)
            {
                if (gameEngine.getMap().getHero().CheckRange(gameEngine.getMap().getEnemy()[i]))
                {
                    comboBoxEnemies.Items.Add(gameEngine.getMap().getEnemy()[i].getType());
                }
            }

        }

        private void lblPlayerInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblMap_Click(object sender, EventArgs e)
        {

        }

        private void lblHitOrMiss_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEnemies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (gameEngine.getMap().getMap()[gameEngine.getMap().getHero().getX(), gameEngine.getMap().getHero().getY() - 1] is Obstacle)
            {

            }
            else
            {
                
                gameEngine.MovePlayer(Character.Movement.Up);
                DisplayMap();
                
            }

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            
            if (gameEngine.getMap().getMap()[gameEngine.getMap().getHero().getX(), gameEngine.getMap().getHero().getY() + 1] is Obstacle)
            {

            }
            else
            {
                
                gameEngine.MovePlayer(Character.Movement.Down);
                DisplayMap();
                
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (gameEngine.getMap().getMap()[gameEngine.getMap().getHero().getX() - 1, gameEngine.getMap().getHero().getY()] is Obstacle)
            {

            }
            else
            {
                
                gameEngine.MovePlayer(Character.Movement.Left);
                DisplayMap();
                
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (gameEngine.getMap().getMap()[gameEngine.getMap().getHero().getX() + 1, gameEngine.getMap().getHero().getY()] is Obstacle)
            {

            }
            else
            {
                
                gameEngine.MovePlayer(Character.Movement.Right);
                DisplayMap();
                
            }
        }
    }
}
