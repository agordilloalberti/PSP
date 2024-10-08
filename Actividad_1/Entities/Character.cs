using System;
using System.Collections.Generic;

namespace Actividad_1.Entities
{
    public class Character
    {
        private String name;
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
            this.maxHealth = maxHealth;
            this.currentHealth = this.maxHealth;
            this.baseDamage = baseDamage;
            this.baseArmor = baseArmor;
        }
        
        public Character(string name, double maxHealth, double baseDamage, double baseArmor, List<Item> items)
        {
            this.name = name;
            this.maxHealth = maxHealth;
            this.currentHealth = maxHealth;
            this.baseDamage = baseDamage;
            this.baseArmor = baseArmor;
            this.inventory = items;
        }

        
        public void setCurrentHealth(double health)
        {
            currentHealth = health;
        }

        public double attack()
        {
            return actualDamage;
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

        public double recieveDamage(double damage)
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

            if (damage<=0)
            {
                return currentHealth;
            }
            
            currentHealth -= damage;
            return currentHealth;
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
    }
}