namespace BuilderAppliance
{
    using Builders;
    using Director;
    using Entities;

    class Program
    {
        static void Main(string[] args)
        {
            var msUserRegister = new UserRegister(new MicrosoftDevUserBuilder());

            msUserRegister.BuildUser();

            MicrosoftUser msDevNewcomer = msUserRegister.GetUser();

            msDevNewcomer.DisplayInfo();
        }
    }
}