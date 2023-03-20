using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chores.Services
{
    public class ChoresService
    {

        private readonly ChoresRepository _repo;

        public ChoresService(ChoresRepository repo)
        {
            _repo = repo;
        }

        internal Chore CreateChore(Chore choreData)
        {
            return _repo.CreateChore(choreData);
        }

        internal Chore FinishedChore(int choreId)
        {
            Chore chore = this.GetChoreById(choreId);
            chore.Finished();
            return chore;
        }

        internal List<Chore> GetAllChores()
        {
            return _repo.GetAllChores();
        }

        internal Chore GetChoreById(int choreId)
        {
            return _repo.GetChoreById(choreId);
        }

        internal string RemoveChore(int choreId)
        {
            Chore chore = this.GetChoreById(choreId);
            bool result = _repo.RemoveChore(choreId);
            if (!result) throw new Exception("Didnt delete for some reason");
            return $"{chore.Name} was never needed again";
        }
    }
}