namespace PrototypeAppliance
{
    class ParsingResult
    {
        public string Title { get; set; }
        public int HeaderTagCount { get; set; }
        public string FirstHeaderTagContents { get; set; }

        #region CONSTRUCTORS

        public ParsingResult(string page)
        {
            Title = "Universitatea Tehnică a Moldovei";
            HeaderTagCount = 3;
            FirstHeaderTagContents =
                "Universitatea Tehnică a Moldovei (UTM). Admiterea, prezentare facultăți, informații pentru studenți.";
        }

        #endregion

        public void Deconstruct(out string title, out int headertagcount, out string firstheadertagcontents)
        {
            title = Title;
            headertagcount = HeaderTagCount;
            firstheadertagcontents = FirstHeaderTagContents;
        }
    }
}