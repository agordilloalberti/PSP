using Actividad_1.Entities;

namespace Actividad_1.Items.Protections
{
    public class Shield
    {
        private double armor = 10;
        private double health = 0;
        public void apply(Character c)
        {
            c.equipProtection(armor,health);
        }
    }
}