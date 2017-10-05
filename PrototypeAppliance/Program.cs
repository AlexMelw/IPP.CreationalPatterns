namespace PrototypeAppliance
{
    class Program
    {
        static void Main(string[] args)
        {
            var scrapper = new WebPageScrapper(@"http://utm.md/");
            var scrapperCopy = (WebPageScrapper) scrapper.Clone();

            scrapper.PrintPageData();
            scrapperCopy.PrintPageData();
        }
    }
}