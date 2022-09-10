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
            lblXandY.Text = gameEngine.getMap().getHero().getX() + " " + gameEngine.getMap().getHero().getY();
            DisplayPlayerInfo();


            Console.WriteLine("Hello");



            DisplayMap();
            FillComboBox();

        }

        public void DisplayMap()
        {
            lblMap.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericMonospace.ToString(), 10);
            lblMap.Text = gameEngine.ToString();
        }

        public void DisplayPlayerInfo()
        {
            lblPlayerInfo.Text = gameEngine.getMap().getHero().ToString();
        }

        public void FillComboBox()
        {
            int count = 0;
            for (int i = 0; i < gameEngine.getMap().getEnemy().Length; i++)
            {
                count++;
                cboEnemies.Items.Add(gameEngine.getMap().getEnemy()[i].getType() + " " + count);
            }

            //For later use probably: if (gameEngine.getMap().getHero().CheckRange(gameEngine.getMap().getEnemy()[i]))
            //{
            //}
        }

        public void attack()
        {
            int selectedEnemy = cboEnemies.SelectedIndex;

            if (gameEngine.getMap().getHero().CheckRange(gameEngine.getMap().getEnemy()[selectedEnemy]))
            {
                lblHitOrMiss.Text = "HIT!";
                gameEngine.getMap().getHero().Attack(gameEngine.getMap().getEnemy()[selectedEnemy]);
            }
            else
            {
                lblHitOrMiss.Text = "MISS!";
            }
        }
        public void destroyTheStupidDuplicatingHeroClones()
        {
            gameEngine.getMap().getMap()[gameEngine.getMap().getHero().getX(), gameEngine.getMap().getHero().getY()] = new EmptyTile(gameEngine.getMap().getHero().getX(), gameEngine.getMap().getHero().getY(), Tile.TileType.Empty);
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

            if (!(gameEngine.getMap().getMap()[gameEngine.getMap().getHero().getX(), gameEngine.getMap().getHero().getY() - 1] is Obstacle))
            {
                destroyTheStupidDuplicatingHeroClones();
                gameEngine.MovePlayer(Character.Movement.Up);

                lblXandY.Text = gameEngine.getMap().getHero().getX() + " " + gameEngine.getMap().getHero().getY();

                DisplayMap();

            }

        }



        private void btnDown_Click(object sender, EventArgs e)
        {

            if (!(gameEngine.getMap().getMap()[gameEngine.getMap().getHero().getX(), gameEngine.getMap().getHero().getY() + 1] is Obstacle))
            {
                destroyTheStupidDuplicatingHeroClones();
                gameEngine.MovePlayer(Character.Movement.Down);
                lblXandY.Text = gameEngine.getMap().getHero().getX() + " " + gameEngine.getMap().getHero().getY();
                DisplayMap();

            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (!(gameEngine.getMap().getMap()[gameEngine.getMap().getHero().getX() - 1, gameEngine.getMap().getHero().getY()] is Obstacle))
            {
                destroyTheStupidDuplicatingHeroClones();
                gameEngine.MovePlayer(Character.Movement.Left);
                lblXandY.Text = gameEngine.getMap().getHero().getX() + " " + gameEngine.getMap().getHero().getY();
                DisplayMap();

            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (!(gameEngine.getMap().getMap()[gameEngine.getMap().getHero().getX() + 1, gameEngine.getMap().getHero().getY()] is Obstacle))
            {
                destroyTheStupidDuplicatingHeroClones();
                gameEngine.MovePlayer(Character.Movement.Right);
                lblXandY.Text = gameEngine.getMap().getHero().getX() + " " + gameEngine.getMap().getHero().getY();
                DisplayMap();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            attack();
        }
    }
}
