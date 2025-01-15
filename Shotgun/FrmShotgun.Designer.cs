namespace Shotgun
{
    partial class FrmShotgun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShotgun));
            lblTitel = new Label();
            lblWelcomeToGame = new Label();
            lblPlayer = new Label();
            lblPlayerAmmo = new Label();
            txtPlayerMove = new TextBox();
            lblShowPlayerAmmo = new Label();
            lblResult = new Label();
            txtRoundResult = new TextBox();
            lblComputer = new Label();
            lblShowComputerAmmo = new Label();
            txtComputerMove = new TextBox();
            lblComputerAmmo = new Label();
            BtnLoad = new Button();
            BtnShoot = new Button();
            BtnBlock = new Button();
            BtnShotgun = new Button();
            lblErrorMessage = new Label();
            BtnRestart = new Button();
            BtnQuitGame = new Button();
            SuspendLayout();
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.BackColor = Color.Gold;
            lblTitel.Font = new Font("Rockwell", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitel.Location = new Point(325, 20);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(564, 64);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "          SHOTGUN           ";
            // 
            // lblWelcomeToGame
            // 
            lblWelcomeToGame.AutoSize = true;
            lblWelcomeToGame.BackColor = Color.Gold;
            lblWelcomeToGame.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWelcomeToGame.Location = new Point(325, 82);
            lblWelcomeToGame.Name = "lblWelcomeToGame";
            lblWelcomeToGame.Size = new Size(565, 32);
            lblWelcomeToGame.TabIndex = 1;
            lblWelcomeToGame.Text = "              Welcome to shotgun! Make your move!      ";
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.BackColor = Color.Gold;
            lblPlayer.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayer.Location = new Point(47, 298);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(117, 38);
            lblPlayer.TabIndex = 3;
            lblPlayer.Text = "PLAYER";
            // 
            // lblPlayerAmmo
            // 
            lblPlayerAmmo.AutoSize = true;
            lblPlayerAmmo.BackColor = Color.Gold;
            lblPlayerAmmo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayerAmmo.Location = new Point(46, 337);
            lblPlayerAmmo.Name = "lblPlayerAmmo";
            lblPlayerAmmo.Size = new Size(78, 30);
            lblPlayerAmmo.TabIndex = 4;
            lblPlayerAmmo.Text = "Ammo";
            // 
            // txtPlayerMove
            // 
            txtPlayerMove.BackColor = Color.Linen;
            txtPlayerMove.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlayerMove.Location = new Point(47, 377);
            txtPlayerMove.Multiline = true;
            txtPlayerMove.Name = "txtPlayerMove";
            txtPlayerMove.Size = new Size(150, 41);
            txtPlayerMove.TabIndex = 5;
            txtPlayerMove.TabStop = false;
            txtPlayerMove.TextAlign = HorizontalAlignment.Center;
            // 
            // lblShowPlayerAmmo
            // 
            lblShowPlayerAmmo.AutoSize = true;
            lblShowPlayerAmmo.BackColor = Color.Gold;
            lblShowPlayerAmmo.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShowPlayerAmmo.Location = new Point(124, 377);
            lblShowPlayerAmmo.Name = "lblShowPlayerAmmo";
            lblShowPlayerAmmo.Size = new Size(0, 30);
            lblShowPlayerAmmo.TabIndex = 6;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Gold;
            lblResult.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(508, 298);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(132, 45);
            lblResult.TabIndex = 7;
            lblResult.Text = "RESULT";
            // 
            // txtRoundResult
            // 
            txtRoundResult.BackColor = Color.Linen;
            txtRoundResult.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoundResult.Location = new Point(414, 373);
            txtRoundResult.Multiline = true;
            txtRoundResult.Name = "txtRoundResult";
            txtRoundResult.ReadOnly = true;
            txtRoundResult.Size = new Size(310, 41);
            txtRoundResult.TabIndex = 8;
            txtRoundResult.TabStop = false;
            // 
            // lblComputer
            // 
            lblComputer.AutoSize = true;
            lblComputer.BackColor = Color.Gold;
            lblComputer.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComputer.Location = new Point(873, 298);
            lblComputer.Name = "lblComputer";
            lblComputer.Size = new Size(168, 38);
            lblComputer.TabIndex = 9;
            lblComputer.Text = "COMPUTER";
            // 
            // lblShowComputerAmmo
            // 
            lblShowComputerAmmo.AutoSize = true;
            lblShowComputerAmmo.BackColor = Color.Gold;
            lblShowComputerAmmo.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShowComputerAmmo.Location = new Point(969, 373);
            lblShowComputerAmmo.Name = "lblShowComputerAmmo";
            lblShowComputerAmmo.Size = new Size(0, 30);
            lblShowComputerAmmo.TabIndex = 12;
            // 
            // txtComputerMove
            // 
            txtComputerMove.BackColor = Color.Linen;
            txtComputerMove.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComputerMove.Location = new Point(873, 377);
            txtComputerMove.Multiline = true;
            txtComputerMove.Name = "txtComputerMove";
            txtComputerMove.ReadOnly = true;
            txtComputerMove.Size = new Size(168, 41);
            txtComputerMove.TabIndex = 11;
            txtComputerMove.TabStop = false;
            txtComputerMove.TextAlign = HorizontalAlignment.Center;
            // 
            // lblComputerAmmo
            // 
            lblComputerAmmo.AutoSize = true;
            lblComputerAmmo.BackColor = Color.Gold;
            lblComputerAmmo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComputerAmmo.Location = new Point(873, 337);
            lblComputerAmmo.Name = "lblComputerAmmo";
            lblComputerAmmo.Size = new Size(78, 30);
            lblComputerAmmo.TabIndex = 10;
            lblComputerAmmo.Text = "Ammo";
            // 
            // BtnLoad
            // 
            BtnLoad.BackColor = Color.Gold;
            BtnLoad.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLoad.Location = new Point(401, 782);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(151, 63);
            BtnLoad.TabIndex = 13;
            BtnLoad.Text = "LOAD";
            BtnLoad.UseVisualStyleBackColor = false;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // BtnShoot
            // 
            BtnShoot.BackColor = Color.Gold;
            BtnShoot.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnShoot.Location = new Point(570, 782);
            BtnShoot.Name = "BtnShoot";
            BtnShoot.Size = new Size(151, 63);
            BtnShoot.TabIndex = 14;
            BtnShoot.Text = "SHOOT";
            BtnShoot.UseVisualStyleBackColor = false;
            BtnShoot.Click += BtnShoot_Click;
            // 
            // BtnBlock
            // 
            BtnBlock.BackColor = Color.Gold;
            BtnBlock.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBlock.Location = new Point(738, 782);
            BtnBlock.Name = "BtnBlock";
            BtnBlock.Size = new Size(151, 63);
            BtnBlock.TabIndex = 15;
            BtnBlock.Text = "BLOCK";
            BtnBlock.UseVisualStyleBackColor = false;
            BtnBlock.Click += BtnBlock_Click;
            // 
            // BtnShotgun
            // 
            BtnShotgun.BackColor = Color.Gold;
            BtnShotgun.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnShotgun.Location = new Point(401, 867);
            BtnShotgun.Name = "BtnShotgun";
            BtnShotgun.Size = new Size(489, 63);
            BtnShotgun.TabIndex = 16;
            BtnShotgun.Text = "SHOTGUN";
            BtnShotgun.UseVisualStyleBackColor = false;
            BtnShotgun.Click += BtnShotgun_Click;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.BackColor = Color.Transparent;
            lblErrorMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblErrorMessage.ForeColor = SystemColors.ButtonHighlight;
            lblErrorMessage.Location = new Point(414, 538);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(0, 32);
            lblErrorMessage.TabIndex = 17;
            // 
            // BtnRestart
            // 
            BtnRestart.BackColor = Color.Gold;
            BtnRestart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRestart.Location = new Point(1154, 20);
            BtnRestart.Name = "BtnRestart";
            BtnRestart.Size = new Size(174, 52);
            BtnRestart.TabIndex = 18;
            BtnRestart.Text = "Play again";
            BtnRestart.UseVisualStyleBackColor = false;
            BtnRestart.Click += BtnRestart_Click;
            // 
            // BtnQuitGame
            // 
            BtnQuitGame.BackColor = Color.Gold;
            BtnQuitGame.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnQuitGame.Location = new Point(1154, 82);
            BtnQuitGame.Name = "BtnQuitGame";
            BtnQuitGame.Size = new Size(174, 52);
            BtnQuitGame.TabIndex = 19;
            BtnQuitGame.Text = "Quit";
            BtnQuitGame.UseVisualStyleBackColor = false;
            BtnQuitGame.Click += BtnQuitGame_Click;
            // 
            // FrmShotgun
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1354, 960);
            Controls.Add(BtnQuitGame);
            Controls.Add(BtnRestart);
            Controls.Add(lblErrorMessage);
            Controls.Add(BtnShotgun);
            Controls.Add(BtnBlock);
            Controls.Add(BtnShoot);
            Controls.Add(BtnLoad);
            Controls.Add(lblShowComputerAmmo);
            Controls.Add(txtComputerMove);
            Controls.Add(lblComputerAmmo);
            Controls.Add(lblComputer);
            Controls.Add(txtRoundResult);
            Controls.Add(lblResult);
            Controls.Add(lblShowPlayerAmmo);
            Controls.Add(txtPlayerMove);
            Controls.Add(lblPlayerAmmo);
            Controls.Add(lblPlayer);
            Controls.Add(lblWelcomeToGame);
            Controls.Add(lblTitel);
            DoubleBuffered = true;
            Name = "FrmShotgun";
            Text = "Shotgun";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitel;
        private Label lblWelcomeToGame;
        private Label lblPlayer;
        private Label lblPlayerAmmo;
        private TextBox txtPlayerMove;
        private Label lblShowPlayerAmmo;
        private Label lblResult;
        private TextBox txtRoundResult;
        private Label lblComputer;
        private Label lblShowComputerAmmo;
        private TextBox txtComputerMove;
        private Label lblComputerAmmo;
        private Button BtnLoad;
        private Button BtnShoot;
        private Button BtnBlock;
        private Button BtnShotgun;
        private Label lblErrorMessage;
        private Button BtnRestart;
        private Button BtnQuitGame;
    }
}