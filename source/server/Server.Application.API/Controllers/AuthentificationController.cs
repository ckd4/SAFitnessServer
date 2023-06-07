using Microsoft.AspNetCore.Mvc;

namespace Server.Presentation.API.Controllers
{
    [Route("api/auth")]
    public class AuthentificationController : Controller
    {
        [HttpGet("register")]
        public async Task<IActionResult> Register()
        {
            // TODO:
            // * implement registration through contracts (idk what arabic people use for auth):
            //   * UserRegistrationResponse (holds id, token and UserRegistrationRequest data)
            //   * UserRegistrationRequest (holds password, email etc.)

            return await Task.Run(() => Ok());
        }

        [HttpGet("login")]
        public async Task<IActionResult> Login()
        {
            // TODO:
            // * implement login through contracts:
            //   * UserRegistrationResponse (holds something similar to UserRegistrationResponse)
            //   * UserRegistrationRequest (holds auth data)

            return await Task.Run(() => Ok());
        }
    }
}
 