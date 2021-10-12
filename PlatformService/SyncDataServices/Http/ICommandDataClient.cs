using System.Threading.Tasks;
using PlatformService.Dtos;

namespace PlatformService.SyncDataSource.Http
{
    public interface ICommandDataClient
    {
        Task SendPlatformToCommand(PlatformReadDto plat);
    }
}