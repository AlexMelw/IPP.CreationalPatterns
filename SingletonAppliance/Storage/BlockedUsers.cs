namespace SingletonAppliance.Storage
{
    using System.Collections.Concurrent;
    using DomainModels;

    public sealed class BlockedUsers
    {
        private static readonly object padlock = new object();
        private static BlockedUsers _instance;

        /// <summary>
        ///     Search key is User's login
        /// </summary>
        public readonly ConcurrentDictionary<string, User> Users;

        public static BlockedUsers Instance
        {
            get {
                lock (padlock)
                {
                    return _instance ?? (_instance = new BlockedUsers());
                }
            }
        }

        #region CONSTRUCTORS

        private BlockedUsers()
        {
            Users = new ConcurrentDictionary<string, User>();
        }

        #endregion


        public bool TryBlockUser(User user)
        {
            if (Users.ContainsKey(user.Login))
            {
                return false;
            }
            return Users.TryAdd(user.Login, user);
        }
    }
}