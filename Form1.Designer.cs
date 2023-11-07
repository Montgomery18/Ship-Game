namespace Ship_Game__Application_
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.PlayArea = new System.Windows.Forms.Panel();
            this.picboxPlayerShip = new System.Windows.Forms.PictureBox();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.lblPla1 = new System.Windows.Forms.Label();
            this.numeupdoDesiredSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblXCoords = new System.Windows.Forms.Label();
            this.lblYCoords = new System.Windows.Forms.Label();
            this.lblPla4 = new System.Windows.Forms.Label();
            this.ritxtboxTutorial = new System.Windows.Forms.RichTextBox();
            this.lblTutorial = new System.Windows.Forms.Label();
            this.btnDisplayTutorial = new System.Windows.Forms.Button();
            this.TutorialContainer = new System.Windows.Forms.Panel();
            this.picboxEnemyStation = new System.Windows.Forms.PictureBox();
            this.PlayArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayerShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeupdoDesiredSpeed)).BeginInit();
            this.TutorialContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEnemyStation)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayArea
            // 
            this.PlayArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.PlayArea.Controls.Add(this.picboxEnemyStation);
            this.PlayArea.Controls.Add(this.picboxPlayerShip);
            this.PlayArea.Location = new System.Drawing.Point(14, 16);
            this.PlayArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlayArea.Name = "PlayArea";
            this.PlayArea.Size = new System.Drawing.Size(1143, 400);
            this.PlayArea.TabIndex = 0;
            // 
            // picboxPlayerShip
            // 
            this.picboxPlayerShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picboxPlayerShip.Image = ((System.Drawing.Image)(resources.GetObject("picboxPlayerShip.Image")));
            this.picboxPlayerShip.Location = new System.Drawing.Point(1090, 173);
            this.picboxPlayerShip.Name = "picboxPlayerShip";
            this.picboxPlayerShip.Size = new System.Drawing.Size(50, 51);
            this.picboxPlayerShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxPlayerShip.TabIndex = 0;
            this.picboxPlayerShip.TabStop = false;
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(913, 651);
            this.btnMoveLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(86, 31);
            this.btnMoveLeft.TabIndex = 3;
            this.btnMoveLeft.Text = "Left";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMovement);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(1047, 651);
            this.btnMoveRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(86, 31);
            this.btnMoveRight.TabIndex = 4;
            this.btnMoveRight.Text = "Right";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMovement);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(981, 703);
            this.btnMoveDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(86, 31);
            this.btnMoveDown.TabIndex = 5;
            this.btnMoveDown.Text = "Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMovement);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(981, 599);
            this.btnMoveUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(86, 31);
            this.btnMoveUp.TabIndex = 7;
            this.btnMoveUp.Text = "Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMovement);
            // 
            // lblPla1
            // 
            this.lblPla1.AutoSize = true;
            this.lblPla1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPla1.Location = new System.Drawing.Point(923, 435);
            this.lblPla1.Name = "lblPla1";
            this.lblPla1.Size = new System.Drawing.Size(209, 20);
            this.lblPla1.TabIndex = 8;
            this.lblPla1.Text = "Choose your speed (max 50)";
            // 
            // numeupdoDesiredSpeed
            // 
            this.numeupdoDesiredSpeed.Location = new System.Drawing.Point(949, 469);
            this.numeupdoDesiredSpeed.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numeupdoDesiredSpeed.Name = "numeupdoDesiredSpeed";
            this.numeupdoDesiredSpeed.Size = new System.Drawing.Size(150, 27);
            this.numeupdoDesiredSpeed.TabIndex = 9;
            // 
            // lblXCoords
            // 
            this.lblXCoords.AutoSize = true;
            this.lblXCoords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblXCoords.Location = new System.Drawing.Point(923, 547);
            this.lblXCoords.Name = "lblXCoords";
            this.lblXCoords.Size = new System.Drawing.Size(80, 22);
            this.lblXCoords.TabIndex = 10;
            this.lblXCoords.Text = "X-Coords: ";
            // 
            // lblYCoords
            // 
            this.lblYCoords.AutoSize = true;
            this.lblYCoords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYCoords.Location = new System.Drawing.Point(1047, 547);
            this.lblYCoords.Name = "lblYCoords";
            this.lblYCoords.Size = new System.Drawing.Size(75, 22);
            this.lblYCoords.TabIndex = 11;
            this.lblYCoords.Text = "Y-Coords:";
            // 
            // lblPla4
            // 
            this.lblPla4.AutoSize = true;
            this.lblPla4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPla4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPla4.Location = new System.Drawing.Point(969, 512);
            this.lblPla4.Name = "lblPla4";
            this.lblPla4.Size = new System.Drawing.Size(108, 22);
            this.lblPla4.TabIndex = 12;
            this.lblPla4.Text = "Location Data";
            // 
            // ritxtboxTutorial
            // 
            this.ritxtboxTutorial.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ritxtboxTutorial.Location = new System.Drawing.Point(3, 28);
            this.ritxtboxTutorial.Name = "ritxtboxTutorial";
            this.ritxtboxTutorial.Size = new System.Drawing.Size(179, 393);
            this.ritxtboxTutorial.TabIndex = 13;
            this.ritxtboxTutorial.Text = "";
            // 
            // lblTutorial
            // 
            this.lblTutorial.AutoSize = true;
            this.lblTutorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTutorial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTutorial.Location = new System.Drawing.Point(59, 3);
            this.lblTutorial.Name = "lblTutorial";
            this.lblTutorial.Size = new System.Drawing.Size(65, 22);
            this.lblTutorial.TabIndex = 14;
            this.lblTutorial.Text = "Tutorial";
            // 
            // btnDisplayTutorial
            // 
            this.btnDisplayTutorial.Location = new System.Drawing.Point(754, 876);
            this.btnDisplayTutorial.Name = "btnDisplayTutorial";
            this.btnDisplayTutorial.Size = new System.Drawing.Size(123, 29);
            this.btnDisplayTutorial.TabIndex = 15;
            this.btnDisplayTutorial.Text = "Display Tutorial";
            this.btnDisplayTutorial.UseVisualStyleBackColor = true;
            // 
            // TutorialContainer
            // 
            this.TutorialContainer.Controls.Add(this.lblTutorial);
            this.TutorialContainer.Controls.Add(this.ritxtboxTutorial);
            this.TutorialContainer.Location = new System.Drawing.Point(723, 483);
            this.TutorialContainer.Name = "TutorialContainer";
            this.TutorialContainer.Size = new System.Drawing.Size(184, 423);
            this.TutorialContainer.TabIndex = 16;
            this.TutorialContainer.Visible = false;
            // 
            // picboxEnemyStation
            // 
            this.picboxEnemyStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picboxEnemyStation.Image = ((System.Drawing.Image)(resources.GetObject("picboxEnemyStation.Image")));
            this.picboxEnemyStation.Location = new System.Drawing.Point(3, 173);
            this.picboxEnemyStation.Name = "picboxEnemyStation";
            this.picboxEnemyStation.Size = new System.Drawing.Size(60, 60);
            this.picboxEnemyStation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxEnemyStation.TabIndex = 1;
            this.picboxEnemyStation.TabStop = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 925);
            this.Controls.Add(this.btnDisplayTutorial);
            this.Controls.Add(this.TutorialContainer);
            this.Controls.Add(this.lblPla4);
            this.Controls.Add(this.lblYCoords);
            this.Controls.Add(this.lblXCoords);
            this.Controls.Add(this.numeupdoDesiredSpeed);
            this.Controls.Add(this.lblPla1);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.PlayArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AltMovement);
            this.PlayArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayerShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeupdoDesiredSpeed)).EndInit();
            this.TutorialContainer.ResumeLayout(false);
            this.TutorialContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEnemyStation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PlayArea;
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
        private RichTextBox ritxtboxTutorial;
        private Label lblTutorial;
        private Button btnDisplayTutorial;
        private Panel TutorialContainer;
        private PictureBox picboxEnemyStation;
    }
}