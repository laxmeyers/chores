using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chores.Repositories;
public class ChoresRepository
{
    private List<Chore> dbChores = new List<Chore>();

    public ChoresRepository()
    {
        dbChores.Add(new Chore(1, "vaccuum", "easy"));
        dbChores.Add(new Chore(2, "mop", "medium"));
        dbChores.Add(new Chore(3, "mow the bunnies", "hard"));
    }

    internal Chore CreateChore(Chore choreData)
    {
        choreData.Id = dbChores[dbChores.Count - 1].Id + 1;
        dbChores.Add(choreData);
        return choreData;
    }

    internal List<Chore> GetAllChores()
    {
        return dbChores;
    }

    internal Chore GetChoreById(int choreId)
    {
        Chore chore = dbChores.Find(c => c.Id == choreId);
        if (chore == null) throw new Exception($"{choreId} is not a valid Id");
        return chore;
    }
}