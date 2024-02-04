using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Ninject.Entities;

public class Device
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Purpose { get; set; }

    public string Inventor { get; set; }

    public string Destination { get; set; }
}
