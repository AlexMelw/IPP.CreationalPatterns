namespace SingletonAppliance.Storage
{
    using System;
    using System.Collections.Concurrent;
    using System.Threading;
    using DomainModels;

    public sealed class CorrespondenceManagement
    {
        //private static readonly Lazy<CorrespondenceManagement> Lazy =
        //    new Lazy<CorrespondenceManagement>(() => new CorrespondenceManagement(), isThreadSafe: true);

            private static readonly ThreadLocal<CorrespondenceManagement> Lazy = new ThreadLocal<CorrespondenceManagement>(() => new CorrespondenceManagement(), false);

        public readonly ConcurrentDictionary<string, ConcurrentQueue<ChatMessage>> ClientChatMessageQueues;

        public static CorrespondenceManagement Instance => Lazy.Value;

        public bool TryCreateMailboxForUser(User user)
        {
            if (ClientChatMessageQueues.ContainsKey(user.Login))
            {
                return false;
            }
            return ClientChatMessageQueues.TryAdd(user.Login, new ConcurrentQueue<ChatMessage>());
        }

        #region CONSTRUCTORS

        private CorrespondenceManagement()
        {
            ClientChatMessageQueues = new ConcurrentDictionary<string, ConcurrentQueue<ChatMessage>>();
        }

        #endregion
    }
}