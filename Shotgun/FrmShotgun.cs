using Shotgun.Classes;

namespace Shotgun
{
    public partial class FrmShotgun : Form
    {
        Game Game;
        Computer Computer;
        Player Player;
        public FrmShotgun()
        {
            InitializeComponent();
            //Starts the game
            Game = new();
            Player = new("You", 0);
            Computer = new("Computer", 0);
            PrintAmmo();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if(Game.GameOver(txtRoundResult.Text)) 
                PrintRestartMessage();
            else
            {
                ClearErrorMessage();
                Player.Move = MoveType.Load;
                Game.StartRound(Computer, Player);
                PrintRoundResult();
            }
        }

        private void BtnShoot_Click(object sender, EventArgs e)
        {
            if (Game.GameOver(txtRoundResult.Text))
                PrintRestartMessage();
            else if (!Game.PlayerCanShoot(Player))
                lblErrorMessage.Text = "You have no ammo to shoot";
            else
            {
                ClearErrorMessage();
                Player.Move = MoveType.Shoot;
                Game.StartRound(Computer, Player);
                PrintRoundResult();
            }
        }

        private void BtnBlock_Click(object sender, EventArgs e)
        {
            if (Game.GameOver(txtRoundResult.Text))
                PrintRestartMessage();
            else
            {
                ClearErrorMessage();
                Player.Move = MoveType.Block;
                Game.StartRound(Computer, Player);
                PrintRoundResult();
            }
        }

        private void BtnShotgun_Click(object sender, EventArgs e)
        {
            if (Game.GameOver(txtRoundResult.Text))
                PrintRestartMessage();
            else if (!Game.PlayerCanShotgun(Player))
                lblErrorMessage.Text = "You need more ammo to use shotgun";
            else
            {
                ClearErrorMessage();
                Player.Move = MoveType.Shotgun;
                Game.StartRound(Computer, Player);
                PrintRoundResult();
            }
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            Game.ResetGame(Computer, Player);
            ResetForm();
        }

        private void BtnQuitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintRoundResult()
        {
            PrintAmmo();
            txtPlayerMove.Text = $"{Player.Move}".ToUpper();
            txtComputerMove.Text = $"{Computer.Move}".ToUpper();
            txtRoundResult.Text = Game.RoundResult();
        }
        private void ResetForm()
        {
            ClearErrorMessage();
            txtRoundResult.Text = string.Empty;
            txtPlayerMove.Text = string.Empty;
            txtComputerMove.Text = string.Empty;
            PrintAmmo();
        }
        private void PrintAmmo()
        {
            lblShowPlayerAmmo.Text = Player.Ammo.ToString();
            lblShowComputerAmmo.Text = Computer.Ammo.ToString();
        }
        private void ClearErrorMessage()
        {
            lblErrorMessage.Text = string.Empty;
        }
        private void PrintRestartMessage()
        {
            lblErrorMessage.Text = "The game round is complete";
        }
    }
}
