using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Post;

namespace Application.UseCase.Post
{
    public class PostUpdateUseCase : IPostUpdateUseCase
    {
        private readonly IPostUpdateUseCase postUpdateUseCase;

        public int Update(Domain.Entities.Post.Post post)
        {
            return postUpdateUseCase.Update(post);
        }
        public PostUpdateUseCase(IPostUpdateUseCase postUpdateUseCase)
        {
            this.postUpdateUseCase = postUpdateUseCase;
        }
    }
}
