using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace CampaignsWithoutNumber.Server.Hubs
{
  public class BroadcastHub : Hub
  {
    public async Task SendMessage()
    {
      await Clients.All.SendAsync("ReceiveMessage");
    }
  }
}
