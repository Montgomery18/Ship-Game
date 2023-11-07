using System.Diagnostics;

namespace Ship_Game__Application_
{
    public partial class ShipGame : System.Windows.Forms.Form
    {
        //The Read Me txt file explains an issue that occurs on laptops
        private EntityData playerShip;
        private EntityData enemyStation;
        private Random rng;
        private Image forwardShip;
        private Image backwardShip;
        private Image station;
        private Image droneImage;
        private Image destroyedShip;
        private Image destroyedStation;
        private List<PictureBox> drones;
        private int playerCounter; //Used for player weapon cooldown timer

        public ShipGame()
        {
            InitializeComponent();
            //rng object
            rng = new Random();
            //

            //entityData and drones objects
            playerShip = new EntityData(true, "Player", 25, 8, new WeaponData(true, false, 0, 10, 400, 10000));
            //What each value represents for EntityData: isplayer - name -  hp - ac - weaponType
            //What each value represents for WeaponData: cannon - drone - speed - damage - range - cooldown
            //Cooldown is 10000 because timers use intervals in millisecond
            enemyStation = new EntityData(false, "Enemy", 50, 5, new WeaponData(false, true, 20, 5, 0, 7500));
            
            //Adding random names to playerShip and enemyStation via its class member function (this could have been done as a normal function)
            playerShip.setName(playerShip.randomNameExtraction(rng));
            enemyStation.setName(enemyStation.randomNameExtraction(rng));
            //

            drones = new List<PictureBox>();
            //

            //Timers
            timPlayerCooldown.Interval = playerShip.getWeaponType().getCoolDown();
            timEnemyCooldown.Interval = enemyStation.getWeaponType().getCoolDown();
            //

            //Images
            forwardShip = Image.FromFile("Forward_Moving_Ship.png");
            backwardShip = Image.FromFile("Backward_Moving_Ship.png");
            station = Image.FromFile("Main_Enemy.png");
            droneImage = Image.FromFile("Drone.png");
            destroyedShip = Image.FromFile("DestroyedShip.png");
            destroyedStation = Image.FromFile("DestroyedMainEnemy.png");
            //

            //Rich Textboxes
            updatingInfoBoxes();
            //

            //labels
            updateCoords();
            //

            //buttons
            btnResetGame.Enabled = false;
            //
        }

        //Movement events
        private void btnMovement(object sender, EventArgs e)
        {
            if (sender == btnMoveUp) movePlaShip("up") ;
            else if (sender == btnMoveDown) movePlaShip("down");
            else if (sender == btnMoveLeft) movePlaShip("left");
            else if (sender == btnMoveRight) movePlaShip("right");
        }
        private void keyMovement(object sender, KeyEventArgs e)
        {
            //Key movements seem to only work if you are focussed on the button movement controls - This was partially fixed
            //To eloborate clicking the cannon fire button will no longer prevent you from using WASD (the focus is set back to the movement buttons using the .focus() class member function)
            //However the issue still remains when you change the speed (and therefore focus on the numericupdown control)
            //To allow for WASD again you must click one of the movement buttons (therefore refocussing on the movement buttons)
            if (e.KeyValue == 119 || e.KeyValue == 87) movePlaShip("up");
            else if (e.KeyValue == 115 || e.KeyValue == 83) movePlaShip("down");
            else if (e.KeyValue == 97 || e.KeyValue == 65) movePlaShip("left");
            else if (e.KeyValue == 100 || e.KeyValue == 68) movePlaShip("right");
        }
        //

        //Player weapon events
        private void playerFiresCannon(object sender, EventArgs e)
        {
            btnPlayerCannonFire.Enabled = false;
            timPlayerCooldown.Enabled = true;
            playerCounter = (playerShip.getWeaponType().getCoolDown() / 1000); //cooldown is in milliseconds, so to get to normal seconds we divide by a 1000
            lblPlayerCooldown.Text = ("Cooldown: " + playerCounter);
            countdownTimer.Enabled = true;
            btnMoveLeft.Focus(); 
            //Refoucesses the program on the button so when the button is renabled WASD can be used immediately to move around the boat.
            //Before you would have to click on the movement buttons to allow for WASD movement again
            if (playerShip.getWeaponType().getRange() >= picboxPlayerShip.Left)
            {
                rtbLog.Text += "\nYou are in range!";
                damageDone(playerShip.getIsPlayer(), playerShip.getWeaponType().getDamage(), enemyStation.getArmour(), enemyStation.getHealth());
            }
            else
            {
                rtbLog.Text += "\nYour cannon is out of range, move to 400 on the X-coord or less to be in range!";
            }
        }
        //

        //Firing player cannon timers (countdown timer included)
        //Overall this system could potentially be off by a few milliseconds, but to the user its unnoticeable
        private void playerCooldownTick(object sender, EventArgs e)
        {
            //Make countdown
            lblPlayerCooldown.Text = "Cooldown: 0";
            countdownTimer.Enabled = false;
            btnPlayerCannonFire.Enabled = true;
            timPlayerCooldown.Enabled = false;
        }

        private void countingDown(object sender, EventArgs e)
        {
            playerCounter--;
            lblPlayerCooldown.Text = "Cooldown: " + playerCounter;
        }
        //

        //Enemy drone generation and management (timer events)
        private void droneGeneration(object sender, EventArgs e)
        {
            PictureBox explosiveDrones = new PictureBox();
            explosiveDrones.Image = droneImage;
            explosiveDrones.Width = 32;
            explosiveDrones.Height = 22;
            explosiveDrones.SizeMode = PictureBoxSizeMode.Zoom;
            explosiveDrones.Left = 55;
            explosiveDrones.Top = 130;
            playArea.Controls.Add(explosiveDrones); 
            //This showed me how to add things to a panel (you have to put the panels name before Controls) https://stackoverflow.com/questions/6406868/c-sharp-add-controls-to-panel-in-a-loop
            //This gave me a potential reason why the control didn't appear even when added to the panel https://stackoverflow.com/questions/19548964/add-control-to-panel-and-control-doesnt-display-anymore-c-sharp
            drones.Add(explosiveDrones);
        }

        private void droneMovement(object sender, EventArgs e)
        {
            if (drones != null)
            {
                foreach (PictureBox drone in drones)
                {
                    if (drone.Left < picboxPlayerShip.Left)
                    {
                        drone.Left += enemyStation.getWeaponType().getSpeed();
                    }
                    else
                    {
                        drone.Left -= enemyStation.getWeaponType().getSpeed();
                    }
                    if (drone.Top < picboxPlayerShip.Top)
                    {
                        drone.Top += enemyStation.getWeaponType().getSpeed();
                    }
                    else
                    {
                        drone.Top -= enemyStation.getWeaponType().getSpeed();
                    }
                    if (drone.Bounds.IntersectsWith(picboxPlayerShip.Bounds))
                    {
                        playArea.Controls.Remove(drone);
                        drones.Remove(drone);
                        damageDone(enemyStation.getIsPlayer(), enemyStation.getWeaponType().getDamage(), playerShip.getArmour(), playerShip.getHealth());
                        break;
                        /*
                        kinda of a hacky way to get rid of the exception error from deleting an item (drone) from drones while in a foreach.
                        The consequence of doing this is that until the next movement cycle the drones can't damage the player.
                        However, this is kind of good for play experence as the invulnerability for the second may save them from being
                        death stacked (i.e. multiple drones ontop of each other) and instantly killed.
                        */
                    }

                }
            }
            else; //Just do nothing if there aren't any drones present
        }
        //

        //Starting and Resting the game button events
        private void StartGame(object sender, EventArgs e)
        {
            rtbLog.Text = "Hello I am the log :)";
            timEnemyCooldown.Enabled = true;
            btnMoveDown.Enabled = true;
            btnMoveUp.Enabled = true;
            btnMoveLeft.Enabled = true;
            btnMoveRight.Enabled = true;
            btnPlayerCannonFire.Enabled = true;
            numeupdoDesiredSpeed.Enabled = true;
            btnStartGame.Enabled = false;
            btnResetGame.Enabled = true;
            btnChangeNames.Enabled = false;
        }

        private void ResetGame(object sender, EventArgs e)
        {
            endOfCurrentRun();
            picboxPlayerShip.Image = forwardShip;
            playerShip.setHealth(25);
            picboxEnemyStation.Image = station;
            enemyStation.setHealth(50);
            updatingInfoBoxes();
            picboxPlayerShip.Left = 954;
            picboxPlayerShip.Top = 130;
            updateCoords();
            numeupdoDesiredSpeed.Value = 0;
            btnStartGame.Enabled = true;
            btnChangeNames.Enabled = true;
            btnResetGame.Enabled = false;
        }
        //

        //Name Manipulation Events
        private void randomNameChange(object sender, EventArgs e)
        {
            playerShip.setName(playerShip.randomNameExtraction(rng));
            enemyStation.setName(playerShip.randomNameExtraction(rng));
            updatingInfoBoxes();
        }

        private void addName(object sender, EventArgs e)
        {
            string path = "namesforentities.txt";
            string nameToBeAdded = tbNameForTextStorage.Text;
            File.AppendAllText(path,"," + nameToBeAdded);
            if (File.Exists(path))
            {
                List<string> names = File.ReadAllText(path).Split(",").ToList();
                foreach (string name in names)
                {
                    if (name == nameToBeAdded)
                    {
                        tbNameForTextStorage.Text = "";
                        tbNameForTextStorage.PlaceholderText = "Success!";
                        break;
                    }
                    else
                    {
                        tbNameForTextStorage.Text = "";
                        tbNameForTextStorage.PlaceholderText = "Failure!";
                    }
                }
            }
            else
            {
                tbNameForTextStorage.Text = "";
            }
        }
        //

        //Damage management
        public void damageDone(bool isPlayer, int damageDoneByAttacker, int armourOfAttacked, int healthOfAttacked)
        {
            if ((rng.Next(0, armourOfAttacked) % 2) != 0)
            {
                if (isPlayer)
                {
                    rtbLog.Text += "\nOur atack failed to penetrate their armour!";
                }
                else
                {
                    rtbLog.Text += "\nThe explosion failed to penetrate our armour!";
                }
            }
            else
            {
                if (isPlayer)
                {
                    rtbLog.Text += "\nWe dealt " + damageDoneByAttacker + " to them!";
                    enemyStation.setHealth(healthOfAttacked - damageDoneByAttacker);
                    if (enemyStation.getHealth() <= 0)
                    {
                        enemyStation.setHealth(0);
                        updatingInfoBoxes();
                        rtbLog.Text += "\nThe enemy has been defeated!";
                        picboxEnemyStation.Image = destroyedStation;
                        endOfCurrentRun();
                    }
                    else
                    {
                        updatingInfoBoxes();
                    }
                }
                else
                {
                    rtbLog.Text += "\nThey dealt " + damageDoneByAttacker + " to us!";
                    playerShip.setHealth(healthOfAttacked - damageDoneByAttacker);
                    if (playerShip.getHealth() <= 0)
                    {
                        playerShip.setHealth(0);
                        updatingInfoBoxes();
                        rtbLog.Text += "\nYou have perished!";
                        picboxPlayerShip.Image = destroyedShip;
                        endOfCurrentRun();
                    }
                    else
                    {
                        updatingInfoBoxes();
                    }
                }
            }
        }
        //

        //Movement management
        public void movePlaShip(string userInput)
        {
            if (userInput == "up")
            {
                if ((picboxPlayerShip.Top - (numeupdoDesiredSpeed.Value)) < 4)
                {
                    picboxPlayerShip.Top = 4;
                    rtbLog.Text += "\nYou cannot go past here!";
                    updateCoords();
                }
                else
                {
                    picboxPlayerShip.Image = forwardShip;
                    picboxPlayerShip.Top -= Convert.ToInt32(numeupdoDesiredSpeed.Value);
                    updateCoords();

                }
            }
            else if (userInput == "left")
            {
                if ((picboxPlayerShip.Left - (numeupdoDesiredSpeed.Value)) < 3)
                {
                    picboxPlayerShip.Left = 3;
                    rtbLog.Text += "\nYou cannot go past here!";
                    updateCoords();
                }
                else
                {
                    picboxPlayerShip.Image = forwardShip;
                    picboxPlayerShip.Left -= Convert.ToInt32(numeupdoDesiredSpeed.Value);
                    updateCoords();
                }
            }
            else if (userInput == "right")
            {
                if ((picboxPlayerShip.Left + (numeupdoDesiredSpeed.Value)) > 954)
                {
                    picboxPlayerShip.Left = 954;
                    rtbLog.Text += "\nYou cannot go past here!";
                    updateCoords();
                }
                else
                {
                    picboxPlayerShip.Image = backwardShip;
                    picboxPlayerShip.Left += Convert.ToInt32(numeupdoDesiredSpeed.Value);
                    updateCoords();
                }
            }
            else if (userInput == "down")
            {
                if ((picboxPlayerShip.Top + (numeupdoDesiredSpeed.Value)) > 257)
                {
                    picboxPlayerShip.Top = 257;
                    rtbLog.Text += "\nYou cannot go past here!";
                    updateCoords();
                }
                else
                {
                    picboxPlayerShip.Image = forwardShip;
                    picboxPlayerShip.Top += Convert.ToInt32(numeupdoDesiredSpeed.Value);
                    updateCoords();
                }
            }
        }
        //

        //Clearing up and ending the current run
        public void endOfCurrentRun()
        {
            //Disables all timers and then resets the gui cooldown timer (the text visisble to the player) and playerCounter variable to 0.
            timEnemyCooldown.Enabled = false;
            droneMovementTimer.Enabled = false;
            timPlayerCooldown.Enabled = false;
            countdownTimer.Enabled = false;
            lblPlayerCooldown.Text = "Cooldown: " + (playerCounter = 0);
            //
            for (int i = 0; i < (drones.Count); i++)
            {
                playArea.Controls.Remove(drones[i]);
                //Struggled on this one, threw values and different ways of doing it until visual studio pointed out, hey use this value
                //Visual studio kind of unintentionally solved the issue
            }
            drones.Clear();
            btnMoveDown.Enabled = false;
            btnMoveUp.Enabled = false;
            btnMoveLeft.Enabled = false;
            btnMoveRight.Enabled = false;
            btnPlayerCannonFire.Enabled = false;
            numeupdoDesiredSpeed.Enabled = false;
        }
        //

        //Updating data in lbls, boxes, etc
        public void updatingInfoBoxes()
        {
            rtbDisplayPlayerData.Text = "HMS " + playerShip.getName() + "\nHealth: " + playerShip.getHealth();
            rtbDisplayEnemyData.Text = enemyStation.getName() + " Station \nHealth: " + enemyStation.getHealth();
        }
        public void updateCoords()
        {
            lblXCoords.Text = "X-Coords: " + picboxPlayerShip.Left;
            lblYCoords.Text = "Y-Coords: " + picboxPlayerShip.Top;
        }
        //
    }
}