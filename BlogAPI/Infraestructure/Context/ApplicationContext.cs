using Domain.Entities.Post;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Context
{
    public class ApplicationContext : DbContext
    {
        DbSet<Post> Posts { get; set; }
    }
}
