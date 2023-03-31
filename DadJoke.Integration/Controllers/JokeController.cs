using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DadJoke.Integration.Controllers
{
    public class JokeController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public JokeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var httpClient = _httpClientFactory.CreateClient("DadJoke");
            var response = await httpClient.GetAsync("random/joke");
            response.EnsureSuccessStatusCode();
            var res = await response.Content.ReadAsStringAsync();
            var dadJokeResponse = JsonConvert.DeserializeObject<RandomJokeResponse>(res);
            return View(dadJokeResponse);
        }
        public async Task<IActionResult> Count()
        {
            var httpClient = _httpClientFactory.CreateClient("DadJoke");
            var response = await httpClient.GetAsync("joke/count");
            response.EnsureSuccessStatusCode();
            var res = await response.Content.ReadAsStringAsync();
            var jokeCounResponse = JsonConvert.DeserializeObject<JokeCounResponse>(res);
            return View(jokeCounResponse);
        }
    }
}
