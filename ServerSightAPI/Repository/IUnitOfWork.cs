using System;
using System.Threading.Tasks;
using ServerSightAPI.Models;
using ServerSightAPI.Models.Server;

namespace ServerSightAPI.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Server> Servers { get; }
        IGenericRepository<ApiKey> ApiKeys { get; }
        
        IGenericRepository<NetworkAdapterServer> NetworkAdaptersServer { get; }
        IGenericRepository<HardDiskServer> HardDisksServers { get; }
    }
}