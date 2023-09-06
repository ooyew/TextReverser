using Microsoft.AspNetCore.Mvc;
using TextReverser.BLL;
using TextReverser.Data;
using TextReverser.Models;

namespace TextReverser.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HomeController : Controller
    {
        private readonly RequestAPIDbContext _dbContext;
        private readonly ILogger<HomeController> _logger;
        public HomeController(RequestAPIDbContext dbContext, ILogger<HomeController> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult SaveInput(RequestDTO requestDTO)
        {
            try
            {
                _logger.LogInformation("User input: " + requestDTO.Input);

                //Perform validation
                if (string.IsNullOrEmpty(requestDTO.Input)) { throw new Exception("Input cannot be empty!"); }

                var request = new Request()
                {
                    Id = Guid.NewGuid(),
                    Input = requestDTO.Input,
                    ReversedInput = HelperClass.ReversedString(requestDTO.Input)
                };

                _dbContext.Requests.Add(request);
                _dbContext.SaveChanges();

                return Ok(request.ReversedInput);
            }
            catch (Exception ex)
            {
                _logger.LogError("Error occurred with: " + ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult ViewInput()
        {
            return Ok(_dbContext.Requests.ToList());
        }
    }
}
