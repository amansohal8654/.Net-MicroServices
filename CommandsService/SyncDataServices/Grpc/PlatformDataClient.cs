using System.Collections.Generic;
using AutoMapper;
using AutoMapper.Configuration;
using CommandsService.Models;

namespace CommandService.SyncDataSerevices.Grpc
{
    public class PlatformDataClient : IPlatformDataClient
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public PlatformDataClient(IConfiguration configuration, IMapper mapper)
        {
            _configuration = configuration;
            _mapper = mapper;
        }
        public IEnumerable<Platform> ReturnAllPlatforms()
        {
            throw new System.NotImplementedException();
        }
    }
}