using HVManager.DataAccessAPI.Models;
using System.Collections.Generic;

namespace HVManager.DataAccessAPI.Repositories
{
    public interface IHostRepository
    {
        IEnumerable<BaseHost> GetAllHosts();
        //BaseHost GetHostByID(int id);

        //void SaveHost(BaseHost host);
        //void UpdateHost(BaseHost host);
    }
}
