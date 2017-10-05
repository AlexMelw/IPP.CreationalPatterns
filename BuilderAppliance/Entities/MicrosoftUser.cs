namespace BuilderAppliance.Entities
{
    using System;

    class MicrosoftUser
    {
        public string UserName { get; set; }
        public Subscription Subscription { get; set; }
        public Guid LinkedInAssociatedAccountId { get; set; }

        public void DisplayInfo()
        {
            Console.Out.WriteLine(this);
        }

        public override string ToString()
        {
            string newLine = Environment.NewLine;

            return $"{nameof(UserName)}: {UserName}, " + newLine +
                   $"{nameof(Subscription)}: [ {Subscription} ], " + newLine +
                   $"{nameof(LinkedInAssociatedAccountId)}: {LinkedInAssociatedAccountId}";
        }
    }
}