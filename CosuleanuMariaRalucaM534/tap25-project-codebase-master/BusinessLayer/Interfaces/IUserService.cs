using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.ModelDTOs;

namespace BusinessLayer.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserDTO> GetAll();

        UserDTO GetById(int userId);

        void Create(UserDTO user);

        void Update(UserDTO user);

        void Delete(int id);
    }
}