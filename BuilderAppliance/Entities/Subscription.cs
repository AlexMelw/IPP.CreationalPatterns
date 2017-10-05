namespace BuilderAppliance.Entities
{
    using System;
    using Enums;

    class Subscription
    {
        public Guid Id { get; set; }
        public SubscriptionType Type { get; set; }

        #region CONSTRUCTORS

        public Subscription()
        {
            Id = Guid.NewGuid();
        }

        #endregion

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Type)}: {Type}";
        }
    }
}