using MusicalGroup.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace MusicalGroup.DataAccess
{
    public class MusicalGroupContext : DbContext
    {
        public MusicalGroupContext()
            : base("name=MusicalGroupContext")
        {
        }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}