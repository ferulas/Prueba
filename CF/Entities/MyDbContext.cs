using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CF.Entities
{
    public class MyDbContext : DbContext
    {
        public DbSet<People> People { get; set; }

        public DbSet<House> House { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
    }

    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<House> Houses { get; set; }
    }

    public class House
    {
        public int Id { get; set; }
        public string Address { get; set; }

        public int PeopleId { get; set; }

        public People People { get; set; }
    }

}
