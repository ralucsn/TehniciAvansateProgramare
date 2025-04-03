using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IdCardController : ControllerBase
    {
        private readonly IRepository<IdCard> _idCardRepository;

        public IdCardController(IRepository<IdCard> idCardRepository)
        {
            _idCardRepository = idCardRepository;
        }

        [HttpGet("get")]
        public IEnumerable<IdCard> Get()
        {
            return _idCardRepository.GetAll();
        }

        [HttpPost("add")]
        public ObjectResult Add(IdCardDto idCardDto)
        {
            _idCardRepository.Add(new IdCard { Number = idCardDto.Number, PersonId = idCardDto.PersonId });
            _idCardRepository.SaveChanges();

            return Ok("Added successfully.");
        }

        [HttpPut("update")]
        public ObjectResult Update(Guid id, IdCardDto idCardDto)
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
