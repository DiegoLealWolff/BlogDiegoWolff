using BlogDiegoWolff.Store;
using System;

namespace BlogDiegoWolff.Services
{
    public interface IPushSubscriptionStoreAccessor : IDisposable
    {
        IPushSubscriptionStore PushSubscriptionStore { get; }
    }
}