using TheSpartanVideoClub.Models;
using Microsoft.EntityFrameworkCore;


namespace TheSpartanVideoClub.Data.Enums
{
    public class ContextoAppBd : DbContext
    {
        //Constructor
        public ContextoAppBd(DbContextOptions<ContextoAppBd> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Pelicula>().HasKey(am => new
            {
                am.ActorId,
                am.PeliculaId
            });

            modelBuilder.Entity<Actor_Pelicula>().HasOne(m => m.Pelicula).WithMany(am => am.actor_Peliculas).HasForeignKey(m => m.PeliculaId);
            modelBuilder.Entity<Actor_Pelicula>().HasOne(m => m.Actor).WithMany(am => am.actor_Peliculas).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Actor_Pelicula> Actor_Peliculas { get; set; }
        public DbSet<Director> Directors { get; set; }

    }

}


