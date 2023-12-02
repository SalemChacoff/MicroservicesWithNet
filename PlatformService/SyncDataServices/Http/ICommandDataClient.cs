using System.Threading.Tasks;
using PlatformService.Dtos;

namespace PlatformService.SyncDataServices.Htpp
{
  public interface ICommandDataClient
  {
    // POST
    Task SendPlatformToCommand(PlatformReadDto plat);
  }
}