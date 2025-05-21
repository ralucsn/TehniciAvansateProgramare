using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.ModelDTOs;

namespace BusinessLayer.Interfaces
{
    public interface IPostService
    {
        IEnumerable<PostDTO> GetAll();

        PostDTO GetById(int postId);

        void Create(PostDTO post);

        void Update(PostDTO post);

        void Delete(int id);
    }
}
