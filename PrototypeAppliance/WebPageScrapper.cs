namespace PrototypeAppliance {
    using System;
    using System.Net;

    public class WebPageScrapper : ICloneable
    {
        private string _title;
        private int _headerTagCount;
        private string _firstHeaderTagContents;

        #region CONSTRUCTORS

        public WebPageScrapper(string url)
        {
            Console.Out.WriteLine("Downloading your page...");

            var client = new WebClient(); // Slow Internet Connection in UTM
            Scrape(client.DownloadString(url));
        }

        #endregion

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void PrintPageData()
        {
            string newLine = Environment.NewLine;

            Console.Out.WriteLine(newLine);

            Console.WriteLine($"Title: {_title}, " + newLine +
                              $"Header Count: {_headerTagCount}, " + newLine +
                              $"First Header: {_firstHeaderTagContents}");
        }

        private void Scrape(string page)
        {
            ParsingResult result = ParsePage(page);

            (_title, _headerTagCount, _firstHeaderTagContents) = result;
        }

        private ParsingResult ParsePage(string page)
        {
            return new ParsingResult(page);
        }
    }
}