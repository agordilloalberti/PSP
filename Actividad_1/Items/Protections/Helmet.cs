using Actividad_1.Entities;

namespace Actividad_1.Items.Protections
{
    public class Helmet : Protection
    {
        public double armor = 5;
        public double health = 5;
        public override void apply(Character c)
        {
            c.equipProtection(this);
        }
        
        public override double getArmor()
        {
            return armor;
        }

        public override double getHealth()
        {
            return health;
        }
    }
}