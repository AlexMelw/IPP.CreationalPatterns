namespace SingletonAppliance.Storage
{
    using System;
    using System.Collections.Concurrent;
    using DomainModels;

    public sealed class RegisteredUsers
    {
        /// <summary>
        ///     Search key is User's login
        /// </summary>
        public readonly ConcurrentDictionary<string, User> Users;

        private static RegisteredUsers _registeredUsers;

        public static RegisteredUsers Instance => _registeredUsers ?? (_registeredUsers = new RegisteredUsers());

        #region CONSTRUCTORS

        private RegisteredUsers()
        {
            Users = new ConcurrentDictionary<string, User>();
        }

        #endregion


        public bool TryRegisterUser(User user)
        {
            if (Users.ContainsKey(user.Login))
            {
                return false;
            }
            return Users.TryAdd(user.Login, user);
        }
    }
}