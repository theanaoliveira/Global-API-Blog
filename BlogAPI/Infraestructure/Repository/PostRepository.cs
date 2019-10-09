using Application.Repositories;
using Domain.Entities.Post;
using Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infraestructure.Repository
{
    public class PostRepository : IPostReadOnlyRepository, IPostWriteOnlyRepository
    {
        private readonly ApplicationContext applicationContext;

        public int Add(Post post)
        {
            applicationContext.Posts.Add(post);
            return applicationContext.SaveChanges();

        }

        public List<Post> GetAll()
        {
            return applicationContext.Posts.ToList();
        }

        public Post GetById(Guid id)
        {
            return applicationContext.Posts.Find(id); 
        }

        public int Remove(Post post)
        {
            applicationContext.Posts.Remove(post);
            return applicationContext.SaveChanges();
        }

        public int Update(Post post)
        {
            applicationContext.Entry(post).State = EntityState.Modified;
            return applicationContext.SaveChanges();
        }

        public PostRepository(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }
    }
}
