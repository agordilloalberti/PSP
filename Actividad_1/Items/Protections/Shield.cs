using Actividad_1.Entities;

namespace Actividad_1.Items.Protections
{
    public class Shield  : Protection
    {
        private double armor = 10;
        private double health = 0;
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