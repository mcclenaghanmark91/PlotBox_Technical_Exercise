using System.Reflection.Emit;

namespace PlotBoxTechEx.HelperClasses
{
    public class PostcodeResponse
    {
        public int Status { get; set; }
        public Result Result { get; set; }
    }

    public class Result
    {
        public string? Postcode { get; set; }
        public int Quality { get; set; }
        public int Eastings { get; set; }
        public int Northings { get; set; }
        public string? Country { get; set; }
        public string? NHS_HA { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string? European_Electoral_Region { get; set; }
        public string? Primary_Care_Trust { get; set; }
        public string? Region { get; set; }
        public string? LSOA { get; set; }
        public string? MSOA { get; set; }
        public string? Incode { get; set; }
        public string? Outcode { get; set; }
        public string? Parliamentary_Constituency { get; set; }
        public string? Admin_District { get; set; }
        public string? Parish { get; set; }
        public string? Admin_County { get; set; }
        public string? Date_Of_Introduction { get; set; }
        public string? Admin_Ward { get; set; }
        public string? CED { get; set; }
        public string? CCG { get; set; }
        public string? NUTS { get; set; }
        public string? PFA { get; set; }
        public Codes Codes { get; set; }
    }
    public class Codes
    {
        public string? Admin_District { get; set; }
        public string? Admin_County { get; set; }
        public string? Admin_Ward { get; set; }
        public string? Parish { get; set; }
        public string? Parliamentary_Constituency { get; set; }
        public string? CCG { get; set; }
        public string? CCG_ID { get; set; }
        public string? CED { get; set; }
        public string? NUTS { get; set; }
        public string? LSOA { get; set; }
        public string? MSOA { get; set; }
        public string? LAU2 { get; set; }
        public string? PFA { get; set; }
    }
}
