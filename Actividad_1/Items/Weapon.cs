using Actividad_1.Entities;

namespace Actividad_1.Items
{
    public abstract class Weapon : Item
    {
        private double damage;
        public void apply(Character c)
        {
            c.equipWeapon(damage);
        }
    }
}