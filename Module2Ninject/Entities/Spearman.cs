using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Ninject.Entities;

public class Spearman : GameCharacter
{
    public Spearman()
    {
        this.Name = "Списоносець";
        this.Weapon = "Спис";
        this.Damage = 8;
    }
}
