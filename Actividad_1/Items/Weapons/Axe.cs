using Actividad_1.Entities;

namespace Actividad_1.Items.Weapons
{
    public class Axe : Weapon
    {
        private double damage = 5;
        public override void apply(Character c)
        {
            c.equipWeapon(this);
        }
        public override double GetDamage()
        {
            return damage;
        }
    }
}