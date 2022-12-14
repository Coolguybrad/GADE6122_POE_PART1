using System;
using System.Windows.Forms;

namespace GADE6122_POE_PART1
{
    public partial class Form1 : Form
    {
        GameEngine gameEngine = new GameEngine();

        public Form1()
        {
            //Methods to call immediately when the game starts:
            InitializeComponent();

            DisplayPlayerInfo();
            DisplayMap();
            FillComboBox();

        }

        public void DisplayMap()
        {
            //lblMap.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericMonospace.ToString(), 10);
            lblMap.Text = gameEngine.ToString();
        }

        //Changes the labels text to display the hero's stats:
        public void DisplayPlayerInfo()
        {
            lblPlayerInfo.Text = gameEngine.getMap().getHero().ToString();
        }

        //Method which fills the comboBox with the enemies which have been created:
        public void FillComboBox()
        {
            int count = 0;
            for (int i = 0; i < gameEngine.getMap().getEnemy().Length; i++)
            {
                count++;
                cboEnemies.Items.Add(gameEngine.getMap().getEnemy()[i].getType() + " [" + gameEngine.getMap().getEnemy()[i].getX() + ", "+ gameEngine.getMap().getEnemy()[i].getY() +"]");
            }
        }

        //Attack method which is used for attacking targets, and to display the result of the attacks to the player:
        public void attack()
        {
            int selectedEnemy = cboEnemies.SelectedIndex;
            string e1 = "Enemy [" + gameEngine.getMap().getEnemy()[0].getX() + ", " + gameEngine.getMap().getEnemy()[0].getY() + "]";
            string e2 = "Enemy [" + gameEngine.getMap().getEnemy()[1].getX() + ", " + gameEngine.getMap().getEnemy()[1].getY() + "]";
            string e3 = "Enemy [" + gameEngine.getMap().getEnemy()[2].getX() + ", " + gameEngine.getMap().getEnemy()[2].getY() + "]";
            if (cboEnemies.Text == e1|| cboEnemies.Text == e2 || cboEnemies.Text == e3)
            {
                if (gameEngine.getMap().getHero().CheckRange(gameEngine.getMap().getEnemy()[selectedEnemy]))
                {
                    lblHitOrMiss.Text = "HIT!";
                    gameEngine.getMap().getHero().Attack(gameEngine.getMap().getEnemy()[selectedEnemy]);

                    if (gameEngine.getMap().getEnemy()[cboEnemies.SelectedIndex].isDead())
                    {
                        gameEngine.getMap().getMap()[gameEngine.getMap().getHero().getX(), gameEngine.getMap().getHero().getY()] = new EmptyTile(gameEngine.getMap().getHero().getX(), gameEngine.getMap().getHero().getY(), Tile.TileType.Empty);
                    }
                }
                else
                {
                    lblHitOrMiss.Text = "MISS!";
                }
            }
            else
            {
                lblHitOrMiss.Text = "Invalid Enemy Selected";
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

        //Method which is called when the Up button is clicked:
        private void btnUp_Click(object sender, EventArgs e)
        {

            if (!(gameEngine.getMap().getMap()[gameEngine.getMap().getHero().getX(), gameEngine.getMap().getHero().getY() - 1] is Obstacle))
            {
                
                gameEngine.MovePlayer(Character.Movement.Up);
                lblPlayerInfo.Text = gameEngine.getMap().getHero().ToString();
                DisplayMap();
            }
        }

        //Method which is called when the Down button is clicked:
        private void btnDown_Click(object sender, EventArgs e)
        {

            if (!(gameEngine.getMap().getMap()[gameEngine.getMap().getHero().getX(), gameEngine.getMap().getHero().getY() + 1] is Obstacle))
            {
                
                gameEngine.MovePlayer(Character.Movement.Down);
                lblPlayerInfo.Text = gameEngine.getMap().getHero().ToString();
                DisplayMap();
            }
        }

        //Method which is called when the Left button is clicked:
        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (!(gameEngine.getMap().getMap()[gameEngine.getMap().getHero().getX() - 1, gameEngine.getMap().getHero().getY()] is Obstacle))
            {
                
                gameEngine.MovePlayer(Character.Movement.Left);
                lblPlayerInfo.Text = gameEngine.getMap().getHero().ToString();
                DisplayMap();
            }
        }

        //Method which is called when the Right button is clicked:
        private void btnRight_Click(object sender, EventArgs e)
        {
            if (!(gameEngine.getMap().getMap()[gameEngine.getMap().getHero().getX() + 1, gameEngine.getMap().getHero().getY()] is Obstacle))
            {
                
                gameEngine.MovePlayer(Character.Movement.Right);
                lblPlayerInfo.Text = gameEngine.getMap().getHero().ToString();
                DisplayMap();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        ////Method which is called when the Attack button is clicked, it only calls a method:
        private void btnAttack_Click(object sender, EventArgs e)
        {
            attack();
        }
    }
}
