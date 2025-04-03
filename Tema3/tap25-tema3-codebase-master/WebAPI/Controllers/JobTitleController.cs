using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Dto;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobTitleController : ControllerBase
    {
        private readonly IRepository<JobTitle> _jobTitleRepository;

        public JobTitleController(IRepository<JobTitle> jobTitleRepository)
        {
            _jobTitleRepository = jobTitleRepository;
        }

        [HttpGet("get")]
        public IEnumerable<JobTitle> Get()
        {
            return _jobTitleRepository.GetAll();
        }

        [HttpPost("add")]
        public ObjectResult Add(JobTitleDto jobTitleDto)
        {
            _jobTitleRepository.Add(new JobTitle { Title = jobTitleDto.Title, PersId = jobTitleDto.PersId });
            _jobTitleRepository.SaveChanges();

            return Ok("Added successfully.");
        }

        [HttpPut("update")]
        public ObjectResult Update(Guid id, JobTitleDto jobTitleDto)
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
