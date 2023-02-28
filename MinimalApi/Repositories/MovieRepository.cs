using MinimalApi.Models;

namespace MinimalApi.Repositories
{
    public class MovieRepository
    {
        public static List<Movie> Movies = new()
        {  new() { Id = 1, Title = "Eternals", Description = "The Saga of The Eternals, a race of immortal beings who lived on Earth and shaped its history and civilization", Rating =  6.8 },

            new() { Id = 2, Title = "Dune", Description = "Feature adaptation of Frank Herbert's science fiction novel, about the son of a noble family entrsuted with the protection of the most valuable asset and most vital element in the galaxy", Rating = 8.2 },

            new() { Id = 3, Title = "The Harder They Fail", Description = "When an outlaw discovers his enemy is being released from prison, he reunites his gang to seek revenge in this Western", Rating = 6.6 },

            new() { Id = 4, Title = "Red Notice", Description = "An Interpol agent tracks the world's most wanted art thief", Rating = 6.4},

            new() { Id = 5, Title = "No  Time to Die", Description = "James Bond has left active service", Rating = 7.4 },
        };
    }
}
