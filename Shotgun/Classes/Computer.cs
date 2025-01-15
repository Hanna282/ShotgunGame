namespace Shotgun.Classes
{
    public class Computer: Players
    {
        public Computer(string name, int ammo) : base(name, ammo)
        {
        }

        public override void LoadAmmo()
        {
            Ammo++;
        }

        public override void UsedAmmo()
        {
            Ammo--;
        }

        public override bool EnoughAmmo()
        {
            if (Ammo > 0)
                return true;
            else
                return false;
        }

        public override bool CanUseShotgun()
        {
            if (Ammo >= 3)
                return true;
            else
                return false;
        }

        public void MakeMove()
        {
            Random randomMove = new();

            while (true)
            {
                Move = (MoveType)randomMove.Next(Enum.GetNames(typeof(MoveType)).Length);

                if (CanUseShotgun())
                    break;
                else if (EnoughAmmo() && Move != MoveType.Shotgun)
                    break;
                else if (!EnoughAmmo() && Move != MoveType.Shotgun && Move != MoveType.Shoot)
                    break;
            }
        }
    }
}
