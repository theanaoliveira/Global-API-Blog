using System;
using System.Collections.Generic;
using System.Text;
using Application.Repositories;
using Domain.Entities.Post;

namespace Application.UseCase.Post
{
    public class PostGetAllUseCase : IPostGetAllUseCase
    {
        private readonly IPostReadOnlyRepository postReadOnlyRepository;

        public List<Domain.Entities.Post.Post> GetAll()
        {
            return postReadOnlyRepository.GetAll();
        }

        public PostGetAllUseCase(IPostReadOnlyRepository postReadOnlyRepository) 
        {
            this.postReadOnlyRepository = postReadOnlyRepository;
        }

    }
}
