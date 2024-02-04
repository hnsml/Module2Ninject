using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Ninject.Entities;

public class Swordsman : GameCharacter
{
    public Swordsman()
    {
        this.Name = "Мечник";
        this.Weapon = "Меч";
        this.Damage = 10;
    }
}
