namespace PostcodeLookup_CONSOLE
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static string path = "https://api.postcodes.io/postcodes/";

        static async Task Main(string[] args)
        {
            Console.WriteLine("Enter a postcode to search:");
            string postcode = Console.ReadLine();
            string? data = await GetPostcodeInfo(postcode);

            Console.WriteLine(data ?? "No data returned");
        }

        private static async Task<string?> GetPostcodeInfo(string postcode)
        {
            HttpResponseMessage response = await client.GetAsync(path + postcode);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                return data;
            }

            return null;
        }
    }
}