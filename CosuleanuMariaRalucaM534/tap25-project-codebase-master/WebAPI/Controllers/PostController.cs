using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.ModelDTOs;
using BusinessLayer.Implementations;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var posts = _postService.GetAll();
            return Ok(posts);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var post = _postService.GetById(id);
            if (post == null)
                return NotFound();
            return Ok(post);
        }

        [HttpPost]
        public IActionResult Post([FromBody] PostDTO post)
        {
            _postService.Create(post);
            return Ok("Succesfully created");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] PostDTO post)
        {
            if (id != post.PostId)
                return BadRequest();

            _postService.Update(post);
            return Ok("Updated succesfully");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _postService.Delete(id);
            return Ok("Deleted succesfully");
        }
    }
}