namespace Shotgun.Classes
{
    public class Player: Players
    {
        public Player(string name, int ammo) : base(name, ammo)
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
    }
}
