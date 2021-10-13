using System.Threading.Tasks;
using PlatformService.Dtos;

namespace PlatformService.SyncDataSerevices.Http
{
    public interface ICommandDataClient
    {
        Task SendPlatformToCommand(PlatformReadDto plat);
    }
}