using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

namespace WebApi.DbOprations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<MovieStoreDbContext>>()))
            {
                if (context.Movies.Any())
                {
                    return;
                }

                context.Directors.AddRange(
          new Director { Name = "Wachowski", LastName = "Brothers", FilmsDirected = "Matrix", IsActive = true },
          new Director { Name = "Christopher", LastName = "Nolan", FilmsDirected = "Inception", IsActive = true },
          new Director { Name = "James", LastName = "Cameron", FilmsDirected = "Avatar", IsActive = true }
          );
                context.SaveChanges();

                context.Actors.AddRange(
                  new Actor { Name = "Keanu", LastName = "Reeves", PlayedMovies = "Matrix", IsAvtive = true },
                  new Actor { Name = "Laurence", LastName = "Fishburne", PlayedMovies = "Matrix", IsAvtive = true },
                  new Actor { Name = "Leonardo", LastName = "DiCaprio", PlayedMovies = "Inception", IsAvtive = true },
                  new Actor { Name = "Tom", LastName = "Hardy", PlayedMovies = "Inception", IsAvtive = true },
                  new Actor { Name = "Sam", LastName = "Worthington", PlayedMovies = "Avatar", IsAvtive = true },
                  new Actor { Name = "Zoe", LastName = "Saldana", PlayedMovies = "Avatar", IsAvtive = true }
                  );
                context.SaveChanges();

                context.Movies.AddRange(

                    new Movie
                    {
                       
                        GenreID = 1,
                        Title = "Matrix",
                        Year = "1999",
                        Director = "Wachowski Brothers",
                        Actors = "Keanu Reeves, Laurence Fishburne, Anne Moss",
                        Price = 50,
                        IsActive = true

                    },

                    new Movie
                    {
                        
                        GenreID = 2,
                        Title = "Avatar",
                        Year = "2022",
                        Director = "James Cameron",
                        Actors = "Sam Worthington, Zoe Saldana",
                        Price = 45,
                        IsActive = true

                    },
                    new Movie
                    {
                        
                        GenreID = 2,
                        Title = "Inception",
                        Year = "2010",
                        Director = "Christopher Nolan",
                        Actors = "Tom Hardy, Leonardo Dicaprio",
                        Price = 45,
                        IsActive = true

                    }
                    );

                context.Genres.AddRange(
                   new Genre
                   {
                       Name = "Aksiyon "
                   },
                   new Genre
                   {
                       Name = "Bilimkurgu "
                   }
                  
               );
                context.SaveChanges();

                context.Customers.AddRange(
         new Customer
         {
             Name = "Emre",
             LastName = "Taş",
             Email = "ET@gmail.com",
             Password = "123456",
             IsActive = true

         },
         new Customer
         {
             Name = "Neslihan",
             LastName = "Mece",
             Email = "NM@gmail.com",
             Password = "123456",
             IsActive = true

         },
         new Customer
         {
             Name = "Eray",
             LastName = "Yılmaz",
             Email = "EY@gmail.com",
             Password = "123456",
             IsActive = true

         });


                context.SaveChanges();

                context.Orders.AddRange(
                  new Order { CustomerId = 1 , MovieId = 1, purchasedTime = new DateTime(2022, 07, 06) , IsActive = true },
                  new Order { CustomerId = 2 , MovieId = 1, purchasedTime = new DateTime(2022, 12, 05) , IsActive = true },
                  new Order { CustomerId = 3 , MovieId = 2, purchasedTime = new DateTime(2022, 08, 25) , IsActive = true }
                  );

                context.SaveChanges();

            }
        }

    }
}
