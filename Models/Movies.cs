using System.Collections.Generic;

namespace FastFurious
{
    public class Movie
    {
        public string Name { get; set; }
        public int Date { get; set; }
    }

    public static class Films
    {
        public static IEnumerable<Movie> GetFilms()
        {
            yield return new Movie
            {
                Name = "The Fast and the Furious",
                Date = 2001
            };
            yield return new Movie
            {
                Name = "2 Fast 2 Furious",
                Date = 2003
            };
            yield return new Movie
            {
                Name = "Fast & Furious", 
                Date = 2009
            };
            yield return new Movie
            {
                Name = "Fast Five",
                Date = 2011
            };
            yield return new Movie
            {
                Name = "The Fast and the Furious: Tokio Drift",
                Date = 2006
            };
            yield return new Movie
            {
                Name = "Fast & Furious 6",
                Date = 2013
            };
            yield return new Movie
            {
                Name = "Furious 7",
                Date = 2015
            };
            yield return new Movie
            {
                Name = "The Fast of The Furious",
                Date = 2017
            };
            yield return new Movie
            {
                Name = "Fast & Furious Presents: Hobbs & Shaw",
                Date = 2019
            };
            yield return new Movie
            {
                Name = "F9 The Fast Saga",
                Date = 2021
            };
        }

    }

}