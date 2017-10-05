namespace SingletonAppliance.Storage
{
    using System.Collections.Concurrent;
    using DomainModels;

    public sealed class ModeratorsStaff
    {
        /// <summary>
        ///     Search key is User's login
        /// </summary>
        public readonly ConcurrentDictionary<string, User> Users;

        public static ModeratorsStaff Instance = new ModeratorsStaff();

        #region CONSTRUCTORS

        private ModeratorsStaff()
        {
            Users = new ConcurrentDictionary<string, User>();
        }

        #endregion


        public bool TryMakeModerator(User user)
        {
            if (Users.ContainsKey(user.Login))
            {
                return false;
            }
            return Users.TryAdd(user.Login, user);
        }
    }
}