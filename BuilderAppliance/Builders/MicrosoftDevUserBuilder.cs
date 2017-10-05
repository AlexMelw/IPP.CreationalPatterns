namespace BuilderAppliance.Builders
{
    using System;
    using Entities;
    using Enums;
    using Repositories;

    class MicrosoftDevUserBuilder : MicrosoftUserBuilder
    {
        public override void CreateNewUser()
        {
            MicrosoftUser = new MicrosoftUser
            {
                UserName = "RandomNames",
                Subscription = new Subscription()
            };
        }

        public override void ApplyStandardSubscription()
        {
            MicrosoftUser.Subscription.Type = SubscriptionType.Standard;
        }

        public override void CreateAssociatedLinkedInAccount()
        {
            if (LinkedInRepository.GetUser(MicrosoftUser.UserName) == null)
            {
                Guid linkedInProfileId = LinkedInRepository.CreateProfile(MicrosoftUser.UserName);

                MicrosoftUser.LinkedInAssociatedAccountId = linkedInProfileId;
            }
        }
    }
}