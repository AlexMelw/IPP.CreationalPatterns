﻿namespace SingletonAppliance.Storage
{
    using System;
    using System.Collections.Concurrent;
    using DomainModels;

    public sealed class AuthenticatedClients
    {
        private static readonly Lazy<AuthenticatedClients> Lazy =
            new Lazy<AuthenticatedClients>(() => new AuthenticatedClients(), isThreadSafe: true);

        /// <summary>
        ///     Search key is AuthenticatedUser's login
        /// </summary>
        public readonly ConcurrentDictionary<string, AuthClient> Clients;

        public static AuthenticatedClients Instance => Lazy.Value;

        #region CONSTRUCTORS

        private AuthenticatedClients()
        {
            Clients = new ConcurrentDictionary<string, AuthClient>();
        }

        #endregion
    }
}