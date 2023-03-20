using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chores.Models;

public class Chore
{
    public Chore(int id, string name, string dificulty)
    {
        Id = id;
        Name = name;
        Dificulty = dificulty;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Dificulty { get; set; }
    public bool IsDone { get; private set; } = false;

    public void Finished()
    {
        this.IsDone = true;
    }

}
