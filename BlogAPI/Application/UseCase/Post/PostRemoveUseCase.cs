using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Post;

namespace Application.UseCase.Post
{
    public class PostRemoveUseCase : IPostRemoveUseCase
    {
        private readonly Repositories.IPostWriteOnlyRepository postWriteOnlyRepository;

        public int Remove(Domain.Entities.Post.Post post)
        {
            return postWriteOnlyRepository.Remove(post);
        }
        public PostRemoveUseCase(Repositories.IPostWriteOnlyRepository postWriteOnlyRepository)
        {
            this.postWriteOnlyRepository = postWriteOnlyRepository;
        }
    }
}
