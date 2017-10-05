namespace BuilderAppliance.Director
{
    using Builders;
    using Entities;

    class UserRegister
    {
        private readonly MicrosoftUserBuilder _microsoftUserBuilder;

        #region CONSTRUCTORS

        public UserRegister(MicrosoftUserBuilder microsoftUserBuilder)
        {
            _microsoftUserBuilder = microsoftUserBuilder;
        }

        #endregion

        public void BuildUser()
        {
            _microsoftUserBuilder.CreateNewUser();
            _microsoftUserBuilder.ApplyStandardSubscription();
            _microsoftUserBuilder.CreateAssociatedLinkedInAccount();
        }

        public MicrosoftUser GetUser() => _microsoftUserBuilder.MicrosoftUser;
    }
}