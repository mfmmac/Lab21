using Microsoft.AspNetCore.Mvc;
using MovieRegistration.Models;
using MovieRegistration.Services;

namespace MovieRegistration.Controllers
{
    public class MovieRegistrationController : Controller
    {
        private readonly ICapitalizationService _capitalizationService;
        public MovieRegistrationController(ICapitalizationService capitalizationService)
        {
            _capitalizationService = capitalizationService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieRegistrationResultView(MovieRegistrationViewModel movieRegistrationViewModel)
        {
            var result = _capitalizationService.Capitalize(movieRegistrationViewModel);

            return View(result);
        }
    }
}
