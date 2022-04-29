using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using TheSpartanVideoClub.Data.Enums;
using TheSpartanVideoClub.Models;

namespace TheSpartanVideoClub.Data
{
    public class InsercionDatosbd
    {
        public static void Insertar(IApplicationBuilder iaplicationBuiler)
        {
            using (var serviceScope = iaplicationBuiler.ApplicationServices.CreateScope())
            {
                var peticion = serviceScope.ServiceProvider.GetService<ContextoAppBd>();
                peticion.Database.EnsureCreated();

                // Actores
                if (!peticion.Actors.Any())
                {
                    peticion.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            NombreActor = "Actor 1",                           
                            FotoPerfilActor = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            NombreActor = "Actor 2",                           
                            FotoPerfilActor = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            NombreActor = "Actor 3",                          
                            FotoPerfilActor = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            NombreActor = "Actor 4",
                            FotoPerfilActor = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            NombreActor = "Actor 5",                        
                            FotoPerfilActor = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    peticion.SaveChanges();

                }
                // Directores
                if (!peticion.Directors.Any())
                {
                    peticion.Directors.AddRange(new List<Director>()
                    {
                        new Director()
                        {
                            NombreDirector = "Producer 1",                           
                            FotoPerfilDirector = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Director()
                        {
                            NombreDirector = "Producer 2",
                            FotoPerfilDirector = "http://dotnethow.net/images/actors/actor-2.jpeg"

                        },
                        new Director()
                        {
                            NombreDirector = "Producer 3",
                            FotoPerfilDirector = "http://dotnethow.net/images/actors/actor-3.jpeg"

                        },new Director()
                        {
                            NombreDirector = "Producer 4",
                            FotoPerfilDirector = "http://dotnethow.net/images/actors/actor-4.jpeg"

                        },
                        new Director()
                        {
                            NombreDirector = "Producer 5",
                            FotoPerfilDirector = "http://dotnethow.net/images/actors/actor-5.jpeg"

                        },
                    });
                    peticion.SaveChanges();

                }
                // Peliculas
                if (!peticion.Peliculas.Any())
                {
                    peticion.Peliculas.AddRange(new List<Pelicula>()
                    {
                        new Pelicula()
                        {
                            NombrePelicula = "Life",
                            DescripcionPelicula = "This is the Life movie description",                           
                            FotoPerfilPelicula = "http://dotnethow.net/images/movies/movie-3.jpeg",                            
                            DirectorId = 3,
                            CategoriaPelicula = CategoriaPelicula.Documental
                        },

                        new Pelicula()
                        {
                            NombrePelicula = "The Shawshank Redemption",
                            DescripcionPelicula = "This is the Shawshank Redemption description",                          
                            FotoPerfilPelicula = "http://dotnethow.net/images/movies/movie-1.jpeg",                            
                            DirectorId = 1,
                            CategoriaPelicula = CategoriaPelicula.Acción
                        },
                        new Pelicula()
                        {
                            NombrePelicula = "Ghost",
                            DescripcionPelicula = "This is the Ghost movie description",                           
                            FotoPerfilPelicula = "http://dotnethow.net/images/movies/movie-4.jpeg",                            
                            DirectorId = 4,
                            CategoriaPelicula = CategoriaPelicula.Terror
                        },
                        new Pelicula()
                        {
                            NombrePelicula = "Race",
                            DescripcionPelicula = "This is the Race movie description",                            
                            FotoPerfilPelicula = "http://dotnethow.net/images/movies/movie-6.jpeg",                            
                            DirectorId = 2,
                            CategoriaPelicula = CategoriaPelicula.Documental
                        },
                        new Pelicula()
                        {
                            NombrePelicula = "Scoob",
                            DescripcionPelicula = "This is the Scoob movie description",                            
                            FotoPerfilPelicula = "http://dotnethow.net/images/movies/movie-7.jpeg",                            
                            DirectorId = 3,
                            CategoriaPelicula= CategoriaPelicula.Infantil
                        },
                        new Pelicula()
                        {
                            NombrePelicula = "Cold Soles",
                            DescripcionPelicula = "This is the Cold Soles movie description",                            
                            FotoPerfilPelicula = "http://dotnethow.net/images/movies/movie-8.jpeg",                            
                            DirectorId = 5,
                            CategoriaPelicula = CategoriaPelicula.Drama
                        }
                    });
                    peticion.SaveChanges();
                }
                // Actores y peliculas
                if (!peticion.Actor_Peliculas.Any())
                {
                    peticion.Actor_Peliculas.AddRange(new List<Actor_Pelicula>()
                    {
                        new Actor_Pelicula()
                        {
                            ActorId = 1,
                            PeliculaId = 1
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 3,
                            PeliculaId = 1
                        },

                         new Actor_Pelicula()
                        {
                            ActorId = 1,
                            PeliculaId = 2
                        },
                         new Actor_Pelicula()
                        {
                            ActorId = 4,
                            PeliculaId = 2
                        },

                        new Actor_Pelicula()
                        {
                            ActorId = 1,
                            PeliculaId = 3
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 2,
                            PeliculaId = 3
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 5,
                            PeliculaId = 3
                        },


                        new Actor_Pelicula()
                        {
                            ActorId = 2,
                            PeliculaId = 4
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 3,
                            PeliculaId = 4
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 4,
                            PeliculaId = 4
                        },


                        new Actor_Pelicula()
                        {
                            ActorId = 2,
                            PeliculaId = 5
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 3,
                            PeliculaId = 5
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 4,
                            PeliculaId = 5
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 5,
                            PeliculaId = 5
                        },


                        new Actor_Pelicula()
                        {
                            ActorId = 3,
                            PeliculaId = 6
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 4,
                            PeliculaId = 6
                        },
                        new Actor_Pelicula()
                        {
                            ActorId = 5,
                            PeliculaId = 6
                        },
                    });
                    peticion.SaveChanges();
                }
            }


        }
    }
            

 }
  
