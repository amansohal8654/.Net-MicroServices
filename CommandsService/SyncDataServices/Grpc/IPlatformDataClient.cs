using System.Collections.Generic;
using CommandsService.Models;

namespace CommandService.SyncDataSerevices.Grpc
{
    public interface IPlatformDataClient
    {
        IEnumerable<Platform> ReturnAllPlatforms();
    }
}