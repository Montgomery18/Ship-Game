namespace Ship_Game__Application_
{
    partial class ShipGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipGame));
            this.playArea = new System.Windows.Forms.Panel();
            this.picboxPlayerShip = new System.Windows.Forms.PictureBox();
            this.picboxEnemyStation = new System.Windows.Forms.PictureBox();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.lblPla1 = new System.Windows.Forms.Label();
            this.numeupdoDesiredSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblXCoords = new System.Windows.Forms.Label();
            this.lblYCoords = new System.Windows.Forms.Label();
            this.lblPla4 = new System.Windows.Forms.Label();
            this.lblCanFire = new System.Windows.Forms.Label();
            this.timPlayerCooldown = new System.Windows.Forms.Timer(this.components);
            this.timEnemyCooldown = new System.Windows.Forms.Timer(this.components);
            this.btnPlayerCannonFire = new System.Windows.Forms.Button();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.lblPlayerCooldown = new System.Windows.Forms.Label();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.rtbDisplayPlayerData = new System.Windows.Forms.RichTextBox();
            this.rtbDisplayEnemyData = new System.Windows.Forms.RichTextBox();
            this.droneMovementTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.lblForPlayerInfoBox = new System.Windows.Forms.Label();
            this.lblForEnemyInfoBox = new System.Windows.Forms.Label();
            this.btnChangeNames = new System.Windows.Forms.Button();
            this.btnAddNameToTextFile = new System.Windows.Forms.Button();
            this.lblForAddingNames = new System.Windows.Forms.Label();
            this.tbNameForTextStorage = new System.Windows.Forms.TextBox();
            this.playArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayerShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEnemyStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeupdoDesiredSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // playArea
            // 
            this.playArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.playArea.Controls.Add(this.picboxPlayerShip);
            this.playArea.Controls.Add(this.picboxEnemyStation);
            this.playArea.Location = new System.Drawing.Point(12, 12);
            this.playArea.Name = "playArea";
            this.playArea.Size = new System.Drawing.Size(1000, 300);
            this.playArea.TabIndex = 0;
            // 
            // picboxPlayerShip
            // 
            this.picboxPlayerShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picboxPlayerShip.Image = ((System.Drawing.Image)(resources.GetObject("picboxPlayerShip.Image")));
            this.picboxPlayerShip.Location = new System.Drawing.Point(954, 130);
            this.picboxPlayerShip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picboxPlayerShip.Name = "picboxPlayerShip";
            this.picboxPlayerShip.Size = new System.Drawing.Size(44, 38);
            this.picboxPlayerShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxPlayerShip.TabIndex = 0;
            this.picboxPlayerShip.TabStop = false;
            // 
            // picboxEnemyStation
            // 
            this.picboxEnemyStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picboxEnemyStation.Image = ((System.Drawing.Image)(resources.GetObject("picboxEnemyStation.Image")));
            this.picboxEnemyStation.Location = new System.Drawing.Point(3, 130);
            this.picboxEnemyStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picboxEnemyStation.Name = "picboxEnemyStation";
            this.picboxEnemyStation.Size = new System.Drawing.Size(52, 45);
            this.picboxEnemyStation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxEnemyStation.TabIndex = 1;
            this.picboxEnemyStation.TabStop = false;
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Enabled = false;
            this.btnMoveLeft.Location = new System.Drawing.Point(668, 492);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(75, 23);
            this.btnMoveLeft.TabIndex = 3;
            this.btnMoveLeft.Text = "Left";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMovement);
            this.btnMoveLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyMovement);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Enabled = false;
            this.btnMoveRight.Location = new System.Drawing.Point(785, 492);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(75, 23);
            this.btnMoveRight.TabIndex = 4;
            this.btnMoveRight.Text = "Right";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMovement);
            this.btnMoveRight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyMovement);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Enabled = false;
            this.btnMoveDown.Location = new System.Drawing.Point(727, 531);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDown.TabIndex = 5;
            this.btnMoveDown.Text = "Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMovement);
            this.btnMoveDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyMovement);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Enabled = false;
            this.btnMoveUp.Location = new System.Drawing.Point(727, 453);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUp.TabIndex = 7;
            this.btnMoveUp.Text = "Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMovement);
            this.btnMoveUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyMovement);
            // 
            // lblPla1
            // 
            this.lblPla1.AutoSize = true;
            this.lblPla1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPla1.Location = new System.Drawing.Point(677, 330);
            this.lblPla1.Name = "lblPla1";
            this.lblPla1.Size = new System.Drawing.Size(163, 15);
            this.lblPla1.TabIndex = 8;
            this.lblPla1.Text = "Choose your speed (max 50)";
            // 
            // numeupdoDesiredSpeed
            // 
            this.numeupdoDesiredSpeed.Enabled = false;
            this.numeupdoDesiredSpeed.Location = new System.Drawing.Point(699, 356);
            this.numeupdoDesiredSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeupdoDesiredSpeed.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numeupdoDesiredSpeed.Name = "numeupdoDesiredSpeed";
            this.numeupdoDesiredSpeed.Size = new System.Drawing.Size(131, 23);
            this.numeupdoDesiredSpeed.TabIndex = 9;
            // 
            // lblXCoords
            // 
            this.lblXCoords.AutoSize = true;
            this.lblXCoords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblXCoords.Location = new System.Drawing.Point(677, 414);
            this.lblXCoords.Name = "lblXCoords";
            this.lblXCoords.Size = new System.Drawing.Size(65, 17);
            this.lblXCoords.TabIndex = 10;
            this.lblXCoords.Text = "X-Coords: ";
            // 
            // lblYCoords
            // 
            this.lblYCoords.AutoSize = true;
            this.lblYCoords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYCoords.Location = new System.Drawing.Point(785, 414);
            this.lblYCoords.Name = "lblYCoords";
            this.lblYCoords.Size = new System.Drawing.Size(62, 17);
            this.lblYCoords.TabIndex = 11;
            this.lblYCoords.Text = "Y-Coords:";
            // 
            // lblPla4
            // 
            this.lblPla4.AutoSize = true;
            this.lblPla4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPla4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPla4.Location = new System.Drawing.Point(717, 388);
            this.lblPla4.Name = "lblPla4";
            this.lblPla4.Size = new System.Drawing.Size(85, 17);
            this.lblPla4.TabIndex = 12;
            this.lblPla4.Text = "Location Data";
            // 
            // lblCanFire
            // 
            this.lblCanFire.AutoSize = true;
            this.lblCanFire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCanFire.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCanFire.Location = new System.Drawing.Point(741, 566);
            this.lblCanFire.Name = "lblCanFire";
            this.lblCanFire.Size = new System.Drawing.Size(50, 17);
            this.lblCanFire.TabIndex = 14;
            this.lblCanFire.Text = "Cannon";
            // 
            // timPlayerCooldown
            // 
            this.timPlayerCooldown.Tick += new System.EventHandler(this.playerCooldownTick);
            // 
            // timEnemyCooldown
            // 
            this.timEnemyCooldown.Tick += new System.EventHandler(this.droneGeneration);
            // 
            // btnPlayerCannonFire
            // 
            this.btnPlayerCannonFire.Enabled = false;
            this.btnPlayerCannonFire.Location = new System.Drawing.Point(699, 621);
            this.btnPlayerCannonFire.Name = "btnPlayerCannonFire";
            this.btnPlayerCannonFire.Size = new System.Drawing.Size(138, 23);
            this.btnPlayerCannonFire.TabIndex = 15;
            this.btnPlayerCannonFire.Text = "Fire";
            this.btnPlayerCannonFire.UseVisualStyleBackColor = true;
            this.btnPlayerCannonFire.Click += new System.EventHandler(this.playerFiresCannon);
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countingDown);
            // 
            // lblPlayerCooldown
            // 
            this.lblPlayerCooldown.AutoSize = true;
            this.lblPlayerCooldown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayerCooldown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerCooldown.Location = new System.Drawing.Point(727, 592);
            this.lblPlayerCooldown.Name = "lblPlayerCooldown";
            this.lblPlayerCooldown.Size = new System.Drawing.Size(76, 17);
            this.lblPlayerCooldown.TabIndex = 17;
            this.lblPlayerCooldown.Text = "Cooldown: 0";
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(164, 331);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbLog.Size = new System.Drawing.Size(235, 323);
            this.rtbLog.TabIndex = 18;
            this.rtbLog.Text = "";
            // 
            // rtbDisplayPlayerData
            // 
            this.rtbDisplayPlayerData.Location = new System.Drawing.Point(405, 389);
            this.rtbDisplayPlayerData.Name = "rtbDisplayPlayerData";
            this.rtbDisplayPlayerData.ReadOnly = true;
            this.rtbDisplayPlayerData.Size = new System.Drawing.Size(100, 96);
            this.rtbDisplayPlayerData.TabIndex = 19;
            this.rtbDisplayPlayerData.Text = "";
            // 
            // rtbDisplayEnemyData
            // 
            this.rtbDisplayEnemyData.Location = new System.Drawing.Point(405, 514);
            this.rtbDisplayEnemyData.Name = "rtbDisplayEnemyData";
            this.rtbDisplayEnemyData.ReadOnly = true;
            this.rtbDisplayEnemyData.Size = new System.Drawing.Size(100, 96);
            this.rtbDisplayEnemyData.TabIndex = 20;
            this.rtbDisplayEnemyData.Text = "";
            // 
            // droneMovementTimer
            // 
            this.droneMovementTimer.Enabled = true;
            this.droneMovementTimer.Interval = 1000;
            this.droneMovementTimer.Tick += new System.EventHandler(this.droneMovement);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(521, 415);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(118, 23);
            this.btnStartGame.TabIndex = 21;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.StartGame);
            // 
            // btnResetGame
            // 
            this.btnResetGame.Location = new System.Drawing.Point(521, 454);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(118, 23);
            this.btnResetGame.TabIndex = 22;
            this.btnResetGame.Text = "Reset Game";
            this.btnResetGame.UseVisualStyleBackColor = true;
            this.btnResetGame.Click += new System.EventHandler(this.ResetGame);
            // 
            // lblForPlayerInfoBox
            // 
            this.lblForPlayerInfoBox.AutoSize = true;
            this.lblForPlayerInfoBox.Location = new System.Drawing.Point(424, 371);
            this.lblForPlayerInfoBox.Name = "lblForPlayerInfoBox";
            this.lblForPlayerInfoBox.Size = new System.Drawing.Size(65, 15);
            this.lblForPlayerInfoBox.TabIndex = 23;
            this.lblForPlayerInfoBox.Text = "Player Ship";
            // 
            // lblForEnemyInfoBox
            // 
            this.lblForEnemyInfoBox.AutoSize = true;
            this.lblForEnemyInfoBox.Location = new System.Drawing.Point(420, 496);
            this.lblForEnemyInfoBox.Name = "lblForEnemyInfoBox";
            this.lblForEnemyInfoBox.Size = new System.Drawing.Size(69, 15);
            this.lblForEnemyInfoBox.TabIndex = 24;
            this.lblForEnemyInfoBox.Text = "Enemy Ship";
            // 
            // btnChangeNames
            // 
            this.btnChangeNames.Location = new System.Drawing.Point(521, 492);
            this.btnChangeNames.Name = "btnChangeNames";
            this.btnChangeNames.Size = new System.Drawing.Size(118, 23);
            this.btnChangeNames.TabIndex = 25;
            this.btnChangeNames.Text = "Change Names";
            this.btnChangeNames.UseVisualStyleBackColor = true;
            this.btnChangeNames.Click += new System.EventHandler(this.randomNameChange);
            // 
            // btnAddNameToTextFile
            // 
            this.btnAddNameToTextFile.Location = new System.Drawing.Point(541, 575);
            this.btnAddNameToTextFile.Name = "btnAddNameToTextFile";
            this.btnAddNameToTextFile.Size = new System.Drawing.Size(75, 23);
            this.btnAddNameToTextFile.TabIndex = 26;
            this.btnAddNameToTextFile.Text = "Add";
            this.btnAddNameToTextFile.UseVisualStyleBackColor = true;
            this.btnAddNameToTextFile.Click += new System.EventHandler(this.addName);
            // 
            // lblForAddingNames
            // 
            this.lblForAddingNames.AutoSize = true;
            this.lblForAddingNames.Location = new System.Drawing.Point(521, 528);
            this.lblForAddingNames.Name = "lblForAddingNames";
            this.lblForAddingNames.Size = new System.Drawing.Size(118, 15);
            this.lblForAddingNames.TabIndex = 27;
            this.lblForAddingNames.Text = "Add name to storage";
            // 
            // tbNameForTextStorage
            // 
            this.tbNameForTextStorage.Location = new System.Drawing.Point(521, 546);
            this.tbNameForTextStorage.Name = "tbNameForTextStorage";
            this.tbNameForTextStorage.Size = new System.Drawing.Size(118, 23);
            this.tbNameForTextStorage.TabIndex = 28;
            this.tbNameForTextStorage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ShipGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 661);
            this.Controls.Add(this.tbNameForTextStorage);
            this.Controls.Add(this.lblForAddingNames);
            this.Controls.Add(this.btnAddNameToTextFile);
            this.Controls.Add(this.btnChangeNames);
            this.Controls.Add(this.lblForEnemyInfoBox);
            this.Controls.Add(this.lblForPlayerInfoBox);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.rtbDisplayEnemyData);
            this.Controls.Add(this.rtbDisplayPlayerData);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.lblPlayerCooldown);
            this.Controls.Add(this.btnPlayerCannonFire);
            this.Controls.Add(this.lblCanFire);
            this.Controls.Add(this.lblPla4);
            this.Controls.Add(this.lblYCoords);
            this.Controls.Add(this.lblXCoords);
            this.Controls.Add(this.numeupdoDesiredSpeed);
            this.Controls.Add(this.lblPla1);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.playArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShipGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ship Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.playArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayerShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEnemyStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeupdoDesiredSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel playArea;
        private Button btnMoveLeft;
        private Button btnMoveRight;
        private Button btnMoveDown;
        private Button btnMoveUp;
        private Label lblPla1;
        private PictureBox picboxPlayerShip;
        private NumericUpDown numeupdoDesiredSpeed;
        private Label lblXCoords;
        private Label lblYCoords;
        private Label lblPla4;
        private PictureBox picboxEnemyStation;
        private Label lblCanFire;
        private System.Windows.Forms.Timer timPlayerCooldown;
        private System.Windows.Forms.Timer timEnemyCooldown;
        private Button btnPlayerCannonFire;
        private System.Windows.Forms.Timer countdownTimer;
        private Label lblPlayerCooldown;
        private RichTextBox rtbLog;
        private RichTextBox rtbDisplayPlayerData;
        private RichTextBox rtbDisplayEnemyData;
        private System.Windows.Forms.Timer droneMovementTimer;
        private Button btnStartGame;
        private Button btnResetGame;
        private Label lblForPlayerInfoBox;
        private Label lblForEnemyInfoBox;
        private Button btnChangeNames;
        private Button btnAddNameToTextFile;
        private Label lblForAddingNames;
        private TextBox tbNameForTextStorage;
    }
}