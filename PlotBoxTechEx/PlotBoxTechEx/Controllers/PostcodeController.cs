using Microsoft.AspNetCore.Mvc;
using PlotBoxTechEx.Models;
using System.Diagnostics;
using Newtonsoft.Json;
using PlotBoxTechEx.HelperClasses;

namespace PlotBoxTechEx.Controllers
{
    public class PostcodeController : Controller
    {
        private readonly ILogger<PostcodeController> _logger;
        private readonly HttpClient _httpClient;

        public PostcodeController(ILogger<PostcodeController> logger)
        {
            _logger = logger;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://api.postcodes.io/");
        }

        public IActionResult PostcodeData()
        {
            return View(new PostcodeViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> PostcodeData(string postcode)
        {
            var model = new PostcodeViewModel();

            try
            {
                //Make a request to the postcodes.io API to lookup postcode
                var initResponse = await _httpClient.GetAsync($"postcodes/{postcode}");

                if(initResponse.IsSuccessStatusCode)
                {
                    //Read through response and parse
                    var jsonResponse = await initResponse.Content.ReadAsStringAsync();

                    //Use Newtonsoft.Json to deserialize the Json
                    var data = JsonConvert.DeserializeObject<PostcodeResponse>(jsonResponse);

                    //Map the data to the view model
                    if(data != null)
                    {
                        model.Postcode = data.Result.Postcode;
                        model.Eastings = data.Result.Eastings;
                        model.Northings = data.Result.Northings;
                        model.Country = data.Result.Country;
                        model.Longitude = data.Result.Longitude;
                        model.Latitude = data.Result.Latitude;
                        model.Admin_District = data.Result.Admin_District;
                        
                    }

                }
                else
                {
                    model.Error = $"Invalid postcode or postcode not found";
                }
                model.ShowResults = true;

            }
            catch (Exception ex)
            {
                model.Error = $"Exception: {ex.Message}";
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}