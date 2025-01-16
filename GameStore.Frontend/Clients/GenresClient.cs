using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class GenresClient
{
    private readonly Genre[] genres =
    [
        new()
        {
            Id = 1,
            Name = "Fighting"
        },
        new()
        {
            Id = 2,
            Name = "Shooter"
        },
        new()
        {
            Id = 3,
            Name = "Adventure"
        },
        new()
        {
            Id = 4,
            Name = "Kids and Family"
        }
    ];
    
    public Genre[] GetGenres() => genres;
}

/*
 * The GenresClient.cs serves two key purposes:
   
   The private genres array holds a predefined collection of game genres with their IDs and names, acting as a simple in-memory data store:
   private readonly Genre[] genres =
   [
       new() { Id = 1, Name = "Fighting" },
       new() { Id = 2, Name = "Shooter" },
       // ...
   ];
   
   Copy
   
   Apply
   
   
   The public GetGenres() method exposes this data to other components while keeping the underlying array private:
   public Genre[] GetGenres() => genres;
   
   Copy
   
   Apply
   
   
   This design follows encapsulation principles where:
   
   The data structure (genres array) stays protected from direct external modification
   Other components can only read the genres through the GetGenres() method
   The implementation details can be changed later without affecting other components that use GenresClient
   The genres are used in both the EditGame.razor component for the genre dropdown selection and in the GamesClient for validating and looking up genre names when adding new games.
 */