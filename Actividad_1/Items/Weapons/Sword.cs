using Actividad_1.Entities;

namespace Actividad_1.Items.Weapons
{
    public class Sword : Weapon
    {
        private double damage = 10;
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