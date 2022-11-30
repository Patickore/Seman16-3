using semana16_1.Models;
using System;
using System.Threading.Tasks;

namespace semana16_1.Data
{
    public class semana16_1Context : DbContext
    {
        public semana16_1Context(DbContextOptions<semana16_1Context> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Teather> Teather { get; set; }

        internal void Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        internal Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        internal void Update(Movie movie)
        {
            throw new NotImplementedException();
        }
    }

    public class Teather
    {
    }

    public class DbContextOptions<T>
    {
    }

    public class DbContext
    {
        private DbContextOptions<semana16_1Context> options;

        public DbContext(DbContextOptions<semana16_1Context> options)
        {
            this.options = options;
        }
    }

    public class DbSet<T>
    {
    }
}
