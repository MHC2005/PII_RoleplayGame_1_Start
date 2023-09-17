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

