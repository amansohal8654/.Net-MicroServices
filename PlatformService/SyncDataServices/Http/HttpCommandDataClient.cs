using System.Net.Http;
using System.Threading.Tasks;
using PlatformService.Dtos;
using PlatformService.SyncDataSource.Http;

namespace PlatformService.SyncDataSerevices.Http
{
     
    public class HttpCommandDataClient : ICommandDataClient
    {
        private readonly HttpClient _httpClient;

        public HttpCommandDataClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task SendPlatformToCommand(PlatformReadDto plat)
        {
            throw new System.NotImplementedException();
        }
    }
}