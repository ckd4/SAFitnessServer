using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Server.Presentation.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class VideoStreamingController : Controller
    {
        private readonly ILogger<AuthentificationController> logger;

        public VideoStreamingController(ILogger<AuthentificationController> logger)
        {
            this.logger = logger;
        }

        [HttpGet("video")]
        public async Task<IActionResult> GetVideoPart(
            //[FromHeader(Name = "Token")] string token,
            [FromQuery(Name = "v")] string videoPartId, 
            [FromQuery(Name = "quality")] int quiality)
        {
            logger.Log(LogLevel.Information, $"<{videoPartId}> sending to {Request.Host.Host}");
            var filestream = System.IO.File.OpenRead(@"D:\Downloads\video.mp4");
            return await Task.Run(() => File(filestream, "video/mpeg"));
        }
    }
}
