namespace Shotgun.Classes
{
    public class Game
    {
        private string _RoundResult = "";
        private bool _Gameover = false;

        public bool GameOver(string textBox)
        {
            if (GameWinner() && textBox != string.Empty)
                return true;
            else
                return false;
        }

        private bool GameWinner()
        {
            if (_Gameover == true)
                return true;
            else
                return false;
        }

        public void StartRound(Computer computer, Player player)
        {
            computer.MakeMove();
            _RoundResult = GetRoundResult(computer, player);
        }

        public string RoundResult()
        {
            return _RoundResult;
        }

        public bool PlayerCanShoot(Player player)
        {
            if (player.EnoughAmmo())
                return true;
            else
                return false;
        }

        public bool PlayerCanShotgun(Player player)
        {
            if (player.CanUseShotgun())
                return true;
            else
                return false;
        }

        public void ResetGame(Computer computer, Player player)
        {
            computer.Ammo = 0;
            player.Ammo = 0;
            _Gameover = false;
        }
        private string GetRoundResult(Computer computer, Player player)
        {
            string roundResult = "";

            if (computer.Move == MoveType.Load && player.Move == MoveType.Load)  
            {
                player.LoadAmmo();
                computer.LoadAmmo();
                roundResult = $"Both players get 1 ammo";
            }
            else if (computer.Move == MoveType.Load && player.Move == MoveType.Block) 
            {
                computer.LoadAmmo();
                roundResult = $"{computer.Name} get 1 ammo";
            }
            else if (player.Move == MoveType.Load && computer.Move == MoveType.Block) 
            {
                player.LoadAmmo();
                roundResult = $"{player.Name} get 1 ammo";
            }
            else if (computer.Move == MoveType.Shoot && player.Move == MoveType.Block) 
            {
                computer.UsedAmmo();
                roundResult = $"{computer.Name} looses 1 ammo";
            }
            else if (player.Move == MoveType.Shoot && computer.Move == MoveType.Block) 
            {
                player.UsedAmmo();
                roundResult = $"{player.Name} looses 1 ammo";
            }
            else if (computer.Move == MoveType.Shoot && player.Move == MoveType.Shoot) 
            {
                //Can´t have less than 0 ammo
                if (player.Ammo > 0)
                    player.UsedAmmo();
                if (computer.Ammo > 0)
                    computer.UsedAmmo();
                roundResult = $"Both players looses 1 ammo";
            }
            else if (computer.Move == MoveType.Shoot && player.Move == MoveType.Load) 
            {
                roundResult = $"{computer.Name} has WON the round!";
                _Gameover = true; 
            }
            else if (player.Move == MoveType.Shoot && computer.Move == MoveType.Load) 
            {
                roundResult = $"{player.Name} has WON the round!";
                _Gameover = true; 
            }
            else if (computer.Move == MoveType.Shotgun && player.Move != MoveType.Shotgun) 
            {
                roundResult = $"{computer.Name} has WON the round!";
                _Gameover = true; 
            }
            else if (player.Move == MoveType.Shotgun && computer.Move != MoveType.Shotgun)
            {
                roundResult = $"{player.Name} has WON the round!";
                _Gameover = true; 
            }
            else if (player.Move == MoveType.Shotgun && computer.Move == MoveType.Shotgun) 
            {
                //Can´t have less than 0 ammo
                if (player.Ammo > 0)
                    player.UsedAmmo();
                if (computer.Ammo > 0)
                    computer.UsedAmmo();
                roundResult = $"Båda förlorar 1 skott";
            }
            else if (computer.Move == MoveType.Block && player.Move == MoveType.Block) 
                roundResult = $"It was a tie!";
            return roundResult;
        }
    }
}
