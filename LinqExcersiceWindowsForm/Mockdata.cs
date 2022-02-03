using System.Collections.Generic;
using System.Linq;

namespace LinqExcersiceWindowsForm
{
    public class Mockdata
    {
        public static List<Movie> GetAllMovies()
        {
            return new List<Movie>
                       {
                           new Movie
                               {
                                   Id = 1,
                                   Title = "Inception",
                                   Director = "Cristopher Nolan",
                                   ReleaseYear = 2010,
                                   Actors = GetAllActors().Where(x => new[] {1, 2, 3}.Contains(x.Id))
                               },
                           new Movie
                               {
                                   Id = 2,
                                   Title = "There will be blood",
                                   Director = "Paul Thomas Anderson",
                                   ReleaseYear = 2007,
                                   Actors = GetAllActors().Where(x => new[] {4, 5}.Contains(x.Id))
                               },
                           new Movie
                               {
                                   Id = 3,
                                   Title = "Primer",
                                   Director = "Shane Carruth",
                                   ReleaseYear = 2004,
                                   Actors = GetAllActors().Where(x => new[] {6}.Contains(x.Id))
                               },
                           new Movie
                               {
                                   Id = 4,
                                   Title = "The Godfather",
                                   Director = "Francis Ford Coppola",
                                   ReleaseYear = 1972,
                                   Actors = GetAllActors().Where(x => new[] {7, 8, 9}.Contains(x.Id))
                               },
                           new Movie
                               {
                                   Id = 5,
                                   Title = "What's eating Gilberg Grape?",
                                   Director = "Lasse Hallström",
                                   ReleaseYear = 1993,
                                   Actors = GetAllActors().Where(x => new[] {1, 10}.Contains(x.Id))
                               },
                           new Movie
                               {
                                   Id = 6,
                                   Title = "Donnie Brasco",
                                   Director = "Mike Newell",
                                   ReleaseYear = 1997,
                                   Actors = GetAllActors().Where(x => new[] {8, 10}.Contains(x.Id))
                               },
                           new Movie
                               {
                                   Id = 7,
                                   Title = "Gangs of New York",
                                   Director = "Martin Scorsese",
                                   ReleaseYear = 2002,
                                   Actors = GetAllActors().Where(x => new[] {1, 4}.Contains(x.Id))
                               },
                           new Movie
                               {
                                   Id = 8,
                                   Title = "Alien",
                                   Director = "Ridley Scott",
                                   ReleaseYear = 1979,
                                   Actors = GetAllActors().Where(x => new[] {11, 12, 13}.Contains(x.Id))
                               },
                           new Movie
                               {
                                   Id = 9,
                                   Title = "The Aviator",
                                   Director = "Martin Scorsese",
                                   ReleaseYear = 2004,
                                   Actors = GetAllActors().Where(x => new[] {1, 14, 15}.Contains(x.Id))
                               },
                           new Movie
                               {
                                   Id = 10,
                                   Title = "Age of Innocence",
                                   Director = "Martin Scorsese",
                                   ReleaseYear = 1993,
                                   Actors = GetAllActors().Where(x => new[] {4, 16}.Contains(x.Id))
                               },
                           new Movie
                               {
                                   Id = 11,
                                   Title = "Tinker Tailor Soldier Spy",
                                   Director = "Tomas Alfredson",
                                   ReleaseYear = 2011,
                                   Actors = GetAllActors().Where(x => new[] {13, 5}.Contains(x.Id))
                               }

                       };
        }

        public static List<Actor> GetAllActors()
        {
            return new List<Actor>
                       {
                           new Actor {Id = 1, Name = "Leonardo DiCaprio", Birthyear = 1974},
                           new Actor {Id = 2, Name = "Joseph Gordon-Levitt", Birthyear = 1981},
                           new Actor {Id = 3, Name = "Ellen Page", Birthyear = 1987},
                           new Actor {Id = 4, Name = "Daniel Day Lewis", Birthyear = 1957},
                           new Actor {Id = 5, Name = "Ciarán Hinds", Birthyear = 1953},
                           new Actor {Id = 6, Name = "Shane Carruth", Birthyear = 1972},
                           new Actor {Id = 7, Name = "Marlon Brando", Birthyear = 1924},
                           new Actor {Id = 8, Name = "Al Pacino", Birthyear = 1940},
                           new Actor {Id = 9, Name = "Robert Duvall", Birthyear = 1931},
                           new Actor {Id = 10, Name = "Johnny Depp", Birthyear = 1963},
                           new Actor {Id = 11, Name = "Sigourney Weaver", Birthyear = 1949},
                           new Actor {Id = 12, Name = "Tom Skeritt", Birthyear = 1933},
                           new Actor {Id = 13, Name = "John Hurt", Birthyear = 1940},
                           new Actor {Id = 14, Name = "Cate Blanchett", Birthyear = 1981},
                           new Actor {Id = 15, Name = "Kate Beckinsale", Birthyear = 1981},
                           new Actor {Id = 16, Name = "Michelle Pfeiffer", Birthyear = 1958}
                       };
        }
    }

    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int ReleaseYear { get; set; }

        public string Director { get; set; }

        public IEnumerable<Actor> Actors { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1}) - {2}", Title, ReleaseYear, Director);
        }
    }

    public class Actor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Birthyear { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

