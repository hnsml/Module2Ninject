using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Ninject.Entities;

public class GameCharacter
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Weapon { get; set; }

    public int Damage { get; set; }
}
