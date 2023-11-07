using System.Diagnostics;

namespace Ship_Game__Application_
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Image forwardShip;
        private Image backwardShip;        
        public Form()
        {
            InitializeComponent();
            //WeaponData playerWeapons = new WeaponData(true, false, false, 0, 20, 10, cooldown, false, 0);
            //EntityData playerShip = new EntityData(50, 10, playerWeapons);

            //WeaponData enemyWeapons = new WeaponData(false, true, true, 10, 5, 0, cooldown, true, 10);
            //EntityData enemyStation = new EntityData(100, 20, enemyWeapons);

            forwardShip = Image.FromFile("Forward_Moving_Ship.png");
            backwardShip = Image.FromFile("Backward_Moving_Ship.png");
            updateCoords();
        }

        private void btnMovement(object sender, EventArgs e)
        {
            //if (sender == btnMoveUp) movePlaShip("up");
            //else 
            movePlaShip(sender);
        }

        private void AltMovement(object sender, KeyEventArgs e)
        {
            //if (e.KeyValue == ???) movePlaShip("up");
            //movePlaShip(sender, e);
        }


        public void movePlaShip(object sender)//, KeyEventArgs e)
        {
            if (sender == btnMoveUp)// || e.KeyValue == 119 || e.KeyValue == 119)
            {
                if ((picboxPlayerShip.Top - (numeupdoDesiredSpeed.Value)) < 4)
                {
                    MessageBox.Show("Prevented");
                }
                else
                {
                    picboxPlayerShip.Image = forwardShip;
                    picboxPlayerShip.Top -= Convert.ToInt32(numeupdoDesiredSpeed.Value);
                    updateCoords();

                }
            }
            else if (sender == btnMoveLeft)
            {
                if ((picboxPlayerShip.Left - (numeupdoDesiredSpeed.Value)) < 3)
                {
                    MessageBox.Show("Prevented");
                }
                else
                {
                    picboxPlayerShip.Image = forwardShip;
                    picboxPlayerShip.Left -= Convert.ToInt32(numeupdoDesiredSpeed.Value);
                    updateCoords();
                }
            }
            else if (sender == btnMoveRight)
            {
                if ((picboxPlayerShip.Left + (numeupdoDesiredSpeed.Value)) > 1090)
                {
                    MessageBox.Show("Prevented");
                }
                else
                {
                    picboxPlayerShip.Image = backwardShip;
                    picboxPlayerShip.Left += Convert.ToInt32(numeupdoDesiredSpeed.Value);
                    updateCoords();
                }
            }
            else if (sender == btnMoveDown)
            {
                if ((picboxPlayerShip.Top + (numeupdoDesiredSpeed.Value)) > 347)
                {
                    MessageBox.Show("Prevented");
                }
                else
                {
                    picboxPlayerShip.Image = forwardShip;
                    picboxPlayerShip.Top += Convert.ToInt32(numeupdoDesiredSpeed.Value);
                    updateCoords();
                }
            }
        }
        public void updateCoords()
        {
            lblXCoords.Text = "X-Coords: " + picboxPlayerShip.Left;
            lblYCoords.Text = "Y-Coords: " + picboxPlayerShip.Top;
        }
    }
}