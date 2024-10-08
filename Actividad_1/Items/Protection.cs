using Actividad_1.Entities;

namespace Actividad_1.Items
{
    public abstract class Protection : Item
    {
        private double armor;
        private double health;
        public void apply(Character c)
        {
            c.equipProtection(armor,health);
        }
    }
}