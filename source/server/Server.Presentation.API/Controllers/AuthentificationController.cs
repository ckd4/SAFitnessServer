using Microsoft.AspNetCore.Mvc;

namespace Server.Presentation.API.Controllers
{
    [Route("api/auth")]
    public class AuthentificationController : Controller
    {
        [HttpPost("register")]
        public async Task<IActionResult> Register()
        {
            // TODO:
            // * implement registration through contracts (idk what arabic people use for auth):
            //   * UserRegistrationResponse (holds id, token and UserRegistrationRequest data)
            //   * UserRegistrationRequest (holds password, email etc.)

            // RETURNS:
            // * 201 CREATED: user registered, UserRegistrationResponse
            // * 400 BAD REQUEST: invalid request data
            // * 409 CONFLICT: there is already user with this data
            // * 502 BAD GATEWAY: server request error
            // * 500 INTERNAL SERVER ERROR: unhadled server error

            return await Task.Run(() => Ok());
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            // TODO:
            // * implement login through contracts:
            //   * UserRegistrationResponse (holds something similar to UserRegistrationResponse)
            //   * UserRegistrationRequest (holds auth data)

            // RETURNS:
            // * 200 OK: login success, UserRegistrationResponse
            // * 404 NOT FOUND: invalid request data
            // * 502 BAD GATEWAY: server request error
            // * 500 INTERNAL SERVER ERROR: unhadled server error

            return await Task.Run(() => Ok());
        }
    }
}