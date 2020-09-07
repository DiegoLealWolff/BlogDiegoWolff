using Lib.Net.Http.WebPush;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogDiegoWolff.Services
{
    public interface IPushService
    {
        Task DiscardSubscriptionAsync(string endpoint);
        string GetKey();
        void SendNotificationAsync(PushMessage message);
        Task<int> StoreSubscriptionAsync([FromBody] PushSubscription subscription);
    }
}
