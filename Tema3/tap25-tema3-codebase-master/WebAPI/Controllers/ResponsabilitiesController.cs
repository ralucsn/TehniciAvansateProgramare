using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResponsabilitiesController : ControllerBase
    {
        private readonly IRepository<Responsabilities> _responsabilitiesRepository;

        public ResponsabilitiesController(IRepository<Responsabilities> responsabilitiesRepository)
        {
            _responsabilitiesRepository = responsabilitiesRepository;
        }

        [HttpGet("get")]
        public IEnumerable<Responsabilities> Get()
        {
            return _responsabilitiesRepository.GetAll();
        }

        [HttpPost("add")]
        public ObjectResult Add(ResponsabilitiesDto responsabilitiesDto)
        {
            _responsabilitiesRepository.Add(new Responsabilities { Title = responsabilitiesDto.Title });
            _responsabilitiesRepository.SaveChanges();

            return Ok("Added successfully.");
        }

        [HttpPut("update")]
        public ObjectResult Update(Guid id, ResponsabilitiesDto responsabilitiesDto)
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
