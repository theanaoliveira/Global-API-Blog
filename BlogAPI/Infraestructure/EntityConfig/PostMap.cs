using Domain.Entities.Post;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.EntityConfig
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("TBL_Post", "Blog"); //nome da tabela com schema chamado blog
            builder.HasKey(x => x.Id); //aqui esta setada uma chave primaria, no caso o id

        }
    }
}
