namespace PlotBoxTechEx.Models
{
    public class PostcodeViewModel
    {
        public string? Postcode { get; set; }
        public int Eastings { get; set; }
        public int Northings { get; set; }
        public string? Country { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string? Admin_District { get; set; }
        public bool ShowResults { get; set; }
        public PostcodeViewModel()
        {
            ShowResults = false;
        }
        public string? Error { get; set; }
    }
}
