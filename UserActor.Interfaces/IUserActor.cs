using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Remoting.FabricTransport;
using Microsoft.ServiceFabric.Services.Remoting;

[assembly: FabricTransportActorRemotingProvider(RemotingListenerVersion = RemotingListenerVersion.V2_1, RemotingClientVersion = RemotingClientVersion.V2_1)]
namespace UserActor.Interfaces
{
    /// <summary>
    ///     Enable Users to manage their shopping cart
    /// </summary>
    public interface IUserActor : IActor
    {
        Task AddToBasket(Guid productId, int quantity);

        Task<BasketItem[]> GetBasket();

        Task ClearBasketAsync();
    }
}
