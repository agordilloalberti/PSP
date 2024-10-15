using System;

namespace Actividad_1.Entities
{
    public class Pet
    {
        private Character owner;
        
        public Pet(string name, double damage, Character owner)
        {
            this.name = name;
            this.damage = damage;
            this.owner = owner;
        }
        
        public Pet(string name, double damage)
        {
            this.name = name;
            this.damage = damage;
            this.owner = null;
        }

        private String name;
        private double damage;
        public String attack(Character c)
        {
            if (owner!=null)
            {
                if (c!=owner)
                {
                    return this.name+" ataca a "+c.getName+ " por "+this.damage+" de daño\n"+c.recieveDamage(damage);
                }
                return "La mascota no puede dañar a su dueño";
            }
            return "La mascota no tiene dueño";
        }
    }
}