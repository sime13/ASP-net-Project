using CepBrasil.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Net.Http;



namespace CepBrasil.Controllers
{
    public class CepController : Controller
    {
        private readonly ApiService _apiService;

        public CepController(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IActionResult> Index(string cep)
        {
            string apiUrl = $"https://viacep.com.br/ws/{cep}/json/";
            string response = await _apiService.GetApiResponseAsync(apiUrl);

            ViewBag.ApiResponse = response;
            return View();
        }

    }
}
