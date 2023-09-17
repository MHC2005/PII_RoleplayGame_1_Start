using System;
using System.Collections.Generic;

namespace Library;
public interface Character
{
    public string Name { get; set; }
    public int  MaxHealth { get; set; }
    public int Health { get; set; }

    

    public void Attack(Character target, int attackPower);

    public void Curar(int vida);
    
}


public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }

        public void ChangeItem(Item currentItem, Item newItem)
        {
            if (Items.Contains(currentItem))
            {
                Items.Remove(currentItem);
                Items.Add(newItem);
            }
        }