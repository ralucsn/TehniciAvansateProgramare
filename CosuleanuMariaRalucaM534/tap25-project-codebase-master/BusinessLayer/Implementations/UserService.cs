using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using BusinessLayer.ModelDTOs;
using DataAccess.Models;
using DataAccess.Repository;

namespace BusinessLayer.Implementations
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;

        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }

        public IEnumerable<UserDTO> GetAll()
        {
            var users = _repository.GetAll();
            return users.Select(m => new UserDTO
            {
                UserId = m.UserId,
                Username = m.Username,
                Email = m.Email
            });
        }

        public UserDTO GetById(int userId)
        {
            var user = _repository.GetById(userId);
            if (user == null) return null;

            return new UserDTO
            {
                UserId = user.UserId,
                Username = user.Username,
                Email = user.Email
            };
        }

        public void Create(UserDTO user)
        {
            var entity = new User
            {
                UserId = user.UserId,
                Username = user.Username,
                Email = user.Email
            };

            _repository.Add(entity);
            _repository.SaveChanges();
        }

        public void Update(UserDTO user)
        {
            var entity = _repository.GetById(user.UserId);
            if (entity == null) throw new KeyNotFoundException("Entity not found");

            entity.Username = user.Username;
            entity.Email = user.Email;
            _repository.Update(entity);
            _repository.SaveChanges();
        }

        public void Delete(int userId)
        {
            var entity = _repository.GetById(userId);
            if (entity == null) throw new KeyNotFoundException("Entity not found");

            _repository.Remove(entity);
            _repository.SaveChanges();
        }
    }
}
