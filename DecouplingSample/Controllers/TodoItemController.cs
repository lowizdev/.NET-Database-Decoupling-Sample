using DecouplingSample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DecouplingSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemController : ControllerBase
    {
        private ITodoService _todoService;
        public TodoItemController(ITodoService todoService)
        {

            _todoService = todoService;

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTodoItem([FromRoute] int id) 
        {
            var result = _todoService.ReadSingle(id);

            return Ok(result); 
        
        }

    }
}
