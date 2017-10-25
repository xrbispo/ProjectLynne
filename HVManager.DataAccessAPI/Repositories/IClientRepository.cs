using HVManager.DataAccessAPI.Models;
using System.Collections.Generic;

namespace HVManager.DataAccessAPI.Repositories
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetAllClients();

    }
}
