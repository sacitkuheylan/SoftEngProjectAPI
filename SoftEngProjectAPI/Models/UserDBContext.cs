using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftEngProjectAPI.Models
{
    public class UserDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {

        }
    }
}
