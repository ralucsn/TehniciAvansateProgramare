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
    public class PostService : IPostService
    {
        private readonly IRepository<Post> _repository;

        public PostService(IRepository<Post> repository)
        {
            _repository = repository;
        }

        public IEnumerable<PostDTO> GetAll()
        {
            var posts = _repository.GetAll();
            return posts.Select(m => new PostDTO
            {
                PostId = m.PostId,
            });
        }

        public PostDTO GetById(int postId)
        {
            var post = _repository.GetById(postId);
            if (post == null) return null;

            return new PostDTO
            {
                PostId = post.PostId
            };
        }

        public void Create(PostDTO post)
        {
            var entity = new Post
            {
                PostId = post.PostId
            };

            _repository.Add(entity);
            _repository.SaveChanges();
        }

        public void Update(PostDTO post)
        {
            var entity = _repository.GetById(post.PostId);
            if (entity == null) throw new KeyNotFoundException("Entity not found");

            entity.PostId = post.PostId;
            _repository.Update(entity);
            _repository.SaveChanges();
        }

        public void Delete(int PostId)
        {
            var entity = _repository.GetById(PostId);
            if (entity == null) throw new KeyNotFoundException("Entity not found");

            _repository.Remove(entity);
            _repository.SaveChanges();
        }
    }
}
