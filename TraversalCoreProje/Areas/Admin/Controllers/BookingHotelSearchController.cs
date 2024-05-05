using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    public class BookingHotelSearchController : Controller
    {
        [AllowAnonymous]
        [Area("Admin")]
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com13.p.rapidapi.com/stays/auto-complete?location=ch&language_code=en-us"),
                Headers =
    {
        { "X-RapidAPI-Key", "0199806a5cmsh398c3799b79b1adp15ac37jsn20258a706b3c" },
        { "X-RapidAPI-Host", "booking-com13.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(body);
                return View(values.data);
            }
        }
    }
}
