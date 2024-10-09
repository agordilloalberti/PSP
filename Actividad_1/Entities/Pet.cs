using System;

namespace Actividad_1.Entities
{
    public class Pet
    {
        public Pet(string name, double damage)
        {
            this.name = name;
            this.damage = damage;
        }

        private String name;
        private double damage;
        public String attack(Character c)
        {
            return this.name+" ataca a "+c.getName+ " por "+this.damage+" de daño\n"+c.recieveDamage(damage);
        }
    }
}