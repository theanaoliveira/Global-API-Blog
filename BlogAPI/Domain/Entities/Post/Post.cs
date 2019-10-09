using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Post
{
    public class Post
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }

        public Post(Guid id, string nome)

        {
            this.Id = id;
            this.Nome = nome;

                    
        }
    }
}
