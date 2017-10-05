namespace SingletonAppliance.Storage
{
    using System.Collections.Concurrent;
    using DomainModels;

    public sealed class VIPUsers
    {
        private static readonly object padlock = new object();
        private static VIPUsers _instance;

        /// <summary>
        ///     Search key is User's login
        /// </summary>
        public readonly ConcurrentDictionary<string, User> Users;

        public static VIPUsers Instance
        {
            get {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        return _instance ?? (_instance = new VIPUsers());
                    }

                }
                return _instance;
            }
        }

        #region CONSTRUCTORS

        private VIPUsers()
        {
            Users = new ConcurrentDictionary<string, User>();
        }

        #endregion


        public bool TryMakeUserVIP(User user)
        {
            if (Users.ContainsKey(user.Login))
            {
                return false;
            }
            return Users.TryAdd(user.Login, user);
        }
    }
}