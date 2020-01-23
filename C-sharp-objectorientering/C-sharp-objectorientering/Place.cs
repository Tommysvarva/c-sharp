namespace C_sharp_objectorientering
{
    class Place
    {
        public string PlaceName { get; private set; }
        public string Municipality { get; private set; }
        public string Region { get; private set; }
      

        public Place(string placeName, string municipality, string region)
        {
            PlaceName = placeName;
            Municipality = municipality;
            Region = region;   
        }
        public  void ShowPlace()
        {
            var LabelWidth = 8;
            GetLineSeperation(LabelWidth);
            ShowFieldNameAndValue("Sted", LabelWidth, PlaceName);
            ShowFieldNameAndValue("Kommune", LabelWidth, Municipality);
            ShowFieldNameAndValue("Fylke", LabelWidth, Region);
            GetLineSeperation(LabelWidth);
        }

        private  void GetLineSeperation(int count)
        {
            count += 12;
            System.Console.WriteLine(string.Empty.PadLeft(count, '*'));
        }
        private  void ShowFieldNameAndValue(string label, int labelWidth, string fieldValue)
        {
            labelWidth -= label.Length;
            System.Console.WriteLine($"{label}:{string.Empty.PadLeft(labelWidth, ' ')} {fieldValue}");
        }
    }
}
