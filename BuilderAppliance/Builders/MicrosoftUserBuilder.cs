namespace BuilderAppliance.Builders
{
    using Entities;

    abstract class MicrosoftUserBuilder
    {
        public MicrosoftUser MicrosoftUser { get; protected set; }

        public abstract void CreateNewUser();
        public abstract void ApplyStandardSubscription();
        public abstract void CreateAssociatedLinkedInAccount();
    }
}