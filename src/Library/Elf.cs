using System;
using System.Collections.Generic;

namespace Library;
public class Elf : Character
{
    public string Name { get; set; }
    public int MaxHealth { get; set; }
    public int Health { get; set; }
    public List<Item> ElfItems { get; set; }

    public Elf(string name, int maxHealth, int power) 
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        ElfItems = new List<Item>();
    }

    public void Attack(Character target, int attackPower)
    {
        target.Health -= attackPower;
    }

    public void Curar(int vida)
    {
        if( vida + this.Health>=MaxHealth){
            Health = MaxHealth;
        }else{
            Health = vida + this.Health;
        }
        
    }


    public void AddItem(Item item)
    {
        ElfItems.Add(item);
    }
}
