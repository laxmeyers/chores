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

        internal List<Chore> GetAllChores()
        {
            return _repo.GetAllChores();
        }

        internal Chore GetChoreById(int choreId)
        {
            return _repo.GetChoreById(choreId);
        }
    }
}