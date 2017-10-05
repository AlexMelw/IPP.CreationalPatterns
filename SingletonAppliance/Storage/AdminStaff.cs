namespace SingletonAppliance.Storage
{
    using System.Collections.Concurrent;
    using DomainModels;

    public sealed class AdminStaff
    {
        /// <summary>
        ///     Search key is User's login
        /// </summary>
        public readonly ConcurrentDictionary<string, User> Users;

        public static AdminStaff Instance
        {
            get { return Nested.Instance; }
        }

        #region CONSTRUCTORS

        private AdminStaff()
        {
            Users = new ConcurrentDictionary<string, User>();
        }

        #endregion


        public bool TryMakeAdmin(User user)
        {
            if (Users.ContainsKey(user.Login))
            {
                return false;
            }
            return Users.TryAdd(user.Login, user);
        }

        private class Nested
        {
            public static readonly AdminStaff Instance = new AdminStaff();

            #region CONSTRUCTORS

            static Nested() { }

            #endregion
        }
    }
}