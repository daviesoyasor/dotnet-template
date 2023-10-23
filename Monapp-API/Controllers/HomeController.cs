using Microsoft.AspNetCore.Mvc;
using Monapp.Service.Interface;
namespace Monapp_API.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IAuth _authService;

        public HomeController(IAuth authService)
        {
            _authService = authService;
        }



        [HttpPost, Route("login")]
        public IActionResult Login (string username, string password)
        {
            Console.WriteLine(username + ":" + password);
            var result = _authService.Login(username, password);
            return Ok(result);
        }

    }


}
