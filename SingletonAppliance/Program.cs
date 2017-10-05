namespace SingletonAppliance
{
    using System;
    using Storage;

    class Program
    {
        static void Main(string[] args)
        {
            CorrespondenceManagement management1 = CorrespondenceManagement.Instance;
            CorrespondenceManagement management2 = CorrespondenceManagement.Instance;

            if (object.ReferenceEquals(management1, management2))
            {
                Console.Out.WriteLine("IS SAME INSTANCE");
            }
        }
    }
}