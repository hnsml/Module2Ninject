using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Ninject.Entities;

public class Bowman : GameCharacter
{
    public Bowman()
    {
        this.Name = "Лучник";
        this.Weapon = "Лук";
        this.Damage = 6;
    }
}
