using Application.Repositories;
using Domain.Entities.Post;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Repository
{
    public class PostRepository : IPostReadOnlyRepository, IPostWriteOnlyRepository
    {
        public int Add(Post post)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public Post GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public int Remove(Post post)
        {
            throw new NotImplementedException();
        }

        public int Update(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
