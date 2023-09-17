using System;
using System.Collections.Generic;


namespace Library;
public class Staff : Item
{

    public string Name { get; set; }
    public int Power { get; set; }
    public Staff(string name, int power)  //estas son las cosas, tipo armas y libros
    {
        this.Name = name;
        this.Power = power;
    }
}