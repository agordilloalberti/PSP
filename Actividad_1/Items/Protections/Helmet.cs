using Actividad_1.Entities;

namespace Actividad_1.Items.Protections
{
    public class Helmet
    {
        private double armor = 5;
        private double health = 5;
        public void apply(Character c)
        {
            c.equipProtection(armor,health);
        }
    }
}