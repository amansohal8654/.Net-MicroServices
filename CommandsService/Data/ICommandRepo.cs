using System.Collections.Generic;
using CommandsService.Models;

namespace CommandService.Data
{
    public interface ICommandRepo
    {
        bool SaveChanges();
        // platforms
        IEnumerable<Platform> GetAllPlatforms();
        void CreatePlatform(Platform plat);
        bool PlatformExists(int platformId);
        bool ExternalPlatformExist(int externalPlatformId);

        // Commands
        IEnumerable<Command> GetCommandsForPlatform(int platformId);
        Command GetCommand(int platformId, int commandId);
        void CreateCommand(int platformId, Command command);
    }
}