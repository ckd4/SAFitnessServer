using Microsoft.AspNetCore.Mvc;
using Module.Business;

namespace API.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthentificationController : Controller
    {
        private readonly ILogger<AuthentificationController> logger;

        public AuthentificationController(ILogger<AuthentificationController> logger)
        {
            this.logger = logger;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(object request)
        {
            // TODO:
            // * implement login through contracts:
            //   * LoginResponse (holds id, token and LoginRequest data)
            //   * LoginRequest (holds auth data)

            // RETURNS:
            // * 200 OK: login success, LoginResponse
            // * 404 NOT FOUND: invalid request data
            // * 502 BAD GATEWAY: server request error
            // * 500 INTERNAL SERVER ERROR: unhandled server error

            return await Task.Run(() => Ok(request));
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(object request)
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
            // * 500 INTERNAL SERVER ERROR: unhandled server error

            return await Task.Run(() => Ok(request));
        }
    }
}
