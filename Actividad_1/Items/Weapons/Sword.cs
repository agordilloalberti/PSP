using Actividad_1.Entities;

namespace Actividad_1.Items.Weapons
{
    public class Sword
    {
        private double damage = 10;
        public void apply(Character c)
        {
            c.equipWeapon(damage);
        }
    }
}