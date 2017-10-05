namespace PrototypeAppliance
{
    using System;
    using System.Collections.Generic;
    using EasySharp.NHelpers.CustomExMethods;
    using Example2;

    partial class Program
    {
        private static void RunDemo1()
        {
            var scrapper = new WebPageScrapper(@"http://utm.md/");
            var scrapperCopy = (WebPageScrapper) scrapper.Clone();

            scrapper.PrintPageData();
            scrapperCopy.PrintPageData();
        }

        private static void RunDemo2()
        {
            var tigerTank = new Tank
            {
                Mobility = new Mobility
                {
                    Power = 900,
                    TopSpeed = 40
                },
                Weaponry = new Weaponry
                {
                    Damage = 490,
                    Penetration = 246
                },
                Crew = new List<CrewType>
                {
                    CrewType.Commander,
                    CrewType.Driver,
                    CrewType.Gunner,
                    CrewType.Loader,
                    CrewType.Loader,
                    CrewType.Radioman
                }
            };

            Tank pantherTank = tigerTank.Replicate();

            tigerTank.Mobility.Power = 333;
            tigerTank.Weaponry.Penetration = 777;

            Console.Out.WriteLine("tigerTank = {0}", tigerTank);
            Console.Out.WriteLine("pantherTank = {0}", pantherTank);
        }

        private static void RunDemo3()
        {
            ArrayReplication.ClonArrayDemo();
        }
    }
}