using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class AngajatController : ControllerBase
    {
        private readonly IRepository<Angajat> _angajatRepository;
        private readonly IRepository<Responsabilities> _responsabilitiesRepository;
    
        public AngajatController(IRepository<Angajat> angajatRepository, IRepository<Responsabilities> responsabilitiesRepository)
        {
            _angajatRepository = angajatRepository;
            _responsabilitiesRepository = responsabilitiesRepository;
        }

        [HttpGet("get")]
        public IEnumerable<Angajat> Get()
        {
            return _angajatRepository.GetAll();
        }

        [HttpGet("find")]
        public IEnumerable<Angajat> Find()
        {
            return _angajatRepository.FindWithInclude(a => true, x => x.Responsabilities);
        }

        [HttpPost("add")]
        public ObjectResult Add(AngajatDto angajatDto)
        {
            _angajatRepository.Add(new Angajat(angajatDto.Name));
            _angajatRepository.SaveChanges();

            return Ok("Added successfully.");
        }

        [HttpPut("go-to")]
        public ObjectResult AddResponsability(Guid angajatId, Guid responsabilitiesId)
        {
            var angajat = _angajatRepository.FindWithInclude(a => a.Id == angajatId, r => r.Responsabilities).FirstOrDefault();
            if (angajat == null)
            {
                return NotFound("Angajat not found.");
            }

            var responsabilities = _responsabilitiesRepository.GetById(responsabilitiesId);
            if (responsabilities == null)
            {
                return NotFound("Responsabilities not found.");
            }

            angajat.Responsabilities.Add(responsabilities);
            _angajatRepository.Update(angajat);
            _angajatRepository.SaveChanges();

            return Ok("Responsabilities added successfully.");
        }

        [HttpPut("update")]
        public ObjectResult Update(Guid id, AngajatDto angajatDto)
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
