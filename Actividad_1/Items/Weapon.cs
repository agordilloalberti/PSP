using Actividad_1.Entities;

namespace Actividad_1.Items
{
    public abstract class Weapon : Item
    {
        private double damage;

        public virtual void apply(Character c)
        {
            c.equipWeapon(this);
        }

        public virtual double GetDamage()
        {
            return damage;
        }
    }
    
}