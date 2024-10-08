using Actividad_1.Entities;

namespace Actividad_1.Items.Weapons
{
    public class Axe : Weapon
    {
        private double damage = 5;
        public void apply(Character c)
        {
            c.equipWeapon(damage);
        }
    }
}