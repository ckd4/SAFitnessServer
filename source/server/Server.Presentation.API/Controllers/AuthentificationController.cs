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
            //   * RegistrationResponse (holds id, token RegistrationRequest data)
            //   * RegistrationRequest (holds password, email etc.)

            // RETURNS:
            // * 201 CREATED: user registered, RegistrationResponse
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
            //   * LoginResponse (holds id, token and LoginRequest data)
            //   * LoginRequest (holds auth data)

            // RETURNS:
            // * 200 OK: login success, LoginResponse
            // * 404 NOT FOUND: invalid request data
            // * 502 BAD GATEWAY: server request error
            // * 500 INTERNAL SERVER ERROR: unhadled server error

            return await Task.Run(() => Ok());
        }
    }
}