using System;
using System.Collections.Generic;

namespace Actividad_1.Entities
{
    public class Character
    {
        private String name;
        private bool dead = false;
        private double maxHealth;
        private double currentHealth;
        private double baseDamage;
        private double baseArmor;
        private double actualDamage;
        private double actualArmor;
        private bool defending = false;
        private List<Item> inventory;

        public Character(string name, double maxHealth, double baseDamage, double baseArmor)
        {
            this.name = name;
            
            if (maxHealth <= 0)
            {
                this.maxHealth = 1;
            }
            else
            {
                this.maxHealth = maxHealth;
            }
            
            this.currentHealth = this.maxHealth;
            this.baseDamage = baseDamage;
            this.baseArmor = baseArmor;
            this.actualArmor = this.baseArmor;
            this.actualDamage = this.baseDamage;
        }
        
        public Character(string name, double maxHealth, double baseDamage, double baseArmor, List<Item> items)
        {
            this.name = name;
            this.maxHealth = maxHealth;
            this.currentHealth = maxHealth;
            this.baseDamage = baseDamage;
            this.baseArmor = baseArmor;
            this.actualArmor = this.baseArmor;
            this.actualDamage = this.baseDamage;
            this.inventory = items;
            foreach (var item in inventory)
            {
                item.apply(this);
            }
        }

        
        public void setCurrentHealth(double health)
        {
            currentHealth = health;
        }

        public String attack(Character c)
        {
            if (c != this && !c.dead)
            {
                String s = c.recieveDamage(actualDamage);
                return this.name + " ataca por " + actualDamage + " daño a "+ c.name+"\n"+ s;
            }

            return "No puedes atacar a este personaje";
        }

        private bool toggleDefense()
        {
            if (!defending)
            {
                defending = true;
                return defending;
            }
            else
            {
                defending = false;
                return defending;
            }
        }

        public double defense()
        {
            toggleDefense();
            return actualArmor;
        }

        public void heal(double hp)
        {
            if ((currentHealth+hp)>maxHealth)
            {
                setCurrentHealth(maxHealth);
            }
            else
            {
                setCurrentHealth(currentHealth + hp);
            }
        }

        public String recieveDamage(double damage)
        {
            if (!dead)
            {
                if (defending)
                {
                    damage -= actualArmor * 1.5;
                    toggleDefense();
                }
                else
                {
                    damage -= actualArmor;
                }

                if (damage <= 0)
                {
                    return "El daño ha sido completamente negado";
                }

                currentHealth -= damage;

                if (currentHealth <= 0)
                {
                    this.dead = true;
                    return this.name + " ha recibido " + damage + " de daño, lo que lo deja fuera de combate";
                }

                return this.name + " ha recibido " + damage + " de daño";
            }
            else
            {
                return this.name + " esta fuera de combate";
            }
        }

        public void equipWeapon(double damage)
        {
            this.actualDamage += damage;
        }

        public void equipProtection(double armor, double health)
        {
            this.actualArmor += armor;
            this.maxHealth += health;
            this.currentHealth = this.maxHealth;
        }

        public override string ToString()
        {
            return "El personaje "+name+" tiene un total de "+maxHealth+" vida máxima " + baseArmor+ " armadura base "
                   + baseDamage +" daño base, la armadura y daño actuales son "+ actualArmor +" y " + actualDamage;
        }
    }
}