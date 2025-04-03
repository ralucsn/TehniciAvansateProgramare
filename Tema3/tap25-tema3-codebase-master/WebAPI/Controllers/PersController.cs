using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersController : ControllerBase
    {
        private readonly IRepository<Pers> _persRepository;

        public PersController(IRepository<Pers> persRepository)
        {
            _persRepository = persRepository;
        }

        [HttpGet("get")]
        public IEnumerable<Pers> Get()
        {
            return _persRepository.GetAll();
        }

        [HttpPost("add")]
        public ObjectResult Add(PersDto persDto)
        {
            _persRepository.Add(new Pers { Name = persDto.Name });
            _persRepository.SaveChanges();

            return Ok("Added successfully.");
        }

        [HttpPut("update")]
        public ObjectResult Update(Guid id, PersDto persDto)
        {
            throw new NotImplementedException();
        }

        [HttpPut("delete")]
        public ObjectResult Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
