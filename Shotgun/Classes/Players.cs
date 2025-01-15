namespace Shotgun.Classes
{
    public abstract class Players
    {
        public string Name { get; }
        public int Ammo { get; set; }
        public MoveType Move { get; set; }

        protected Players(string name, int ammo)
        {
            Name = name;
            Ammo = ammo;
        }

        public abstract void LoadAmmo();
        public abstract void UsedAmmo();
        public abstract bool EnoughAmmo();
        public abstract bool CanUseShotgun();
    }
}
