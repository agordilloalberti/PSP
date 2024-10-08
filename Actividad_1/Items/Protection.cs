using Actividad_1.Entities;

namespace Actividad_1.Items
{
    public abstract class Protection : Item
    {
        private double armor;
        private double health;
        public virtual void apply(Character c)
        {
            c.equipProtection(this);
        }

        public virtual double getArmor()
        {
            return armor;
        }

        public virtual double getHealth()
        {
            return health;
        }
    }
}