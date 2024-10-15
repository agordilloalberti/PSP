using System;
using System.Collections.Generic;
using Actividad_1.Items;

namespace Actividad_1.Entities
{
    public class Character
    {
        private String name;
        private bool dead;
        private double maxHealth;
        private double currentHealth;
        private double baseDamage;
        private double baseArmor;
        private double actualDamage;
        private double actualArmor;
        private bool defending;
        private List<Item> inventory=new List<Item>();
        private List<Pet> pets=new List<Pet>();

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
            if (maxHealth <= 0)
            {
                this.maxHealth = 1;
            }
            else
            {
                this.maxHealth = maxHealth;
            }
            this.currentHealth = maxHealth;
            this.baseDamage = baseDamage;
            this.baseArmor = baseArmor;
            this.actualArmor = this.baseArmor;
            this.actualDamage = this.baseDamage;
            this.inventory = items;
            foreach (var item in inventory)
            {
                item.apply(this);
                heal(Double.MaxValue);
            }
        }
        
        public Character(string name, double maxHealth, double baseDamage, double baseArmor, List<Item> items, List<Pet> pets)
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
            this.currentHealth = maxHealth;
            this.baseDamage = baseDamage;
            this.baseArmor = baseArmor;
            this.actualArmor = this.baseArmor;
            this.actualDamage = this.baseDamage;
            this.inventory = items;
            this.pets = pets;
            foreach (var item in inventory)
            {
                item.apply(this);
                heal(Double.MaxValue);
            }
        }
        
        public Character(string name, double maxHealth, double baseDamage, double baseArmor, List<Pet> pets)
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
            this.currentHealth = maxHealth;
            this.baseDamage = baseDamage;
            this.baseArmor = baseArmor;
            this.actualArmor = this.baseArmor;
            this.actualDamage = this.baseDamage;
            this.pets = pets;
        }

        
        public void setCurrentHealth(double health)
        {
            currentHealth = health;
        }

        public string getName => name;

        public String attack(Character c)
        {
            if (c != this && !c.dead)
            {
                String s = c.recieveDamage(actualDamage);
                if (pets.Count>0)
                {
                    foreach (var pet in pets)
                    {
                        s += "\n"+pet.attack(c);
                    }
                }
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
                    return this.name+" ha repelido el ataque";
                }

                currentHealth -= damage;

                if (currentHealth <= 0)
                {
                    this.dead = true;
                    return this.name + " ha recibido " + damage + " de daño, lo que lo deja fuera de combate";
                }

                return this.name + " ha recibido " + damage + " de daño y se queda con "+this.currentHealth+" de salud";
            }
            return this.name + " esta fuera de combate";
        }

        public void equipWeapon(Weapon w)
        {
            this.actualDamage += w.GetDamage();
        }

        public void equipProtection(Protection p)
        {
            this.actualArmor += p.getArmor();
            this.maxHealth += p.getHealth();
        }

        public void addWeapon(Weapon w)
        {
            inventory.Add(w);
            equipWeapon(w);
        }
        
        public void addProtection(Protection p)
        {
            inventory.Add(p);
            equipProtection(p);
        }

        public void removeProtection(Protection p)
        {
            inventory.Remove(p);
            this.maxHealth -= p.getHealth();
            this.actualArmor -= p.getArmor();
            if (currentHealth < maxHealth)
            {
                this.currentHealth = maxHealth;
            }
        }

        public void removeWeapon(Weapon w)
        {
            inventory.Remove(w);
            this.actualDamage -= w.GetDamage();
        }

        public void addPet(Pet p)
        {
            pets.Add(p);
        }

        public void removePet(Pet p)
        {
            pets.Remove(p);
        }

        public String status()
        {
            return this.name+" tiene "+this.maxHealth+" de vida máxima, "+this.currentHealth+" de vida actual, "
                   +this.actualDamage+" de daño y "+this.actualArmor+" de armadura";
        }

        public String seeInventory()
        {
            string s="";
            foreach (var item in inventory)
            {
                //TODO: completar seeInvetory
            }
            return s;
        }

        public override string ToString()
        {
            return "El personaje "+name+" tiene un total de "+maxHealth+" vida máxima, " + baseArmor+ " armadura base, "
                   + baseDamage +" daño base, la armadura y daño actuales son "+ actualArmor +" y " + actualDamage;
        }
    }
}