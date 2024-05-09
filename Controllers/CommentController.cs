using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BackendWebsite.Models;
using WebsiteContext;
using System;

namespace BackendWebsite.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ILogger<CommentController> _logger;
        private readonly ApplicationDbContext _context;

        public CommentController(ILogger<CommentController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public string Get()
        {
            _logger.LogInformation("Hello from the backend");
            return "you hit it";
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string message)
        {
            try
            {
                var comment = new Comment { Message = message };
                Console.WriteLine("Comment: ", comment.Message);
                _context.Comments.Add(comment);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to save comment");
                return BadRequest();
            }
            return Ok();
        }
    }
}
