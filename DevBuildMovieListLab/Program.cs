using System;
using System.Collections.Generic;
using System.Linq;

namespace DevBuildMovieListLab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*----------------------------------------LAB SUMMARY-----------------------------------------------------------
             * Prompt: How is a class different from an object? How are public methods different from private?
             * 
             * Answer: A class is the blueprint for objects, and vis versa an object is an instance of a class. Private
             *         methods can only be used inside of the class they are declared inside of while public methods can be
             *         used and acessed externally through dot notation. 
             * 
            */

            //Initialize List of Movie objects
            List<Movie> movies = new List<Movie>()
            { 
                new Movie("Corpse Bride","animated"),
                new Movie("Fantastic Mr.Fox","animated"),
                new Movie("Joker","drama"),
                new Movie("Enemy at the Gates","drama"),
                new Movie("Candyman","horror"),
                new Movie("Saw III","horror"),
                new Movie("MIB","scifi"),
                new Movie("MIIB","scifi"),
                new Movie("Spirited Away","animated"),
                new Movie("A Quiet Place","horror")
            };

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine($"There are {movies.Count} movies in theis list.");
            bool keepGoing = true;
            while (keepGoing)
            {
                CategoryPick(movies);
                keepGoing = Continue();
            }
            

            


        }

        public static void CategoryPick(List<Movie> movies)
        {
            string category = GetUserInput("Please enter the category number you would like to search by." +
                "\n[1] Animated" +
                "\n[2] Drama" +
                "\n[3] Horror" +
                "\n[4] SciFi" +
                "\n");

            switch (category)
            {
                case "1":
                    DisplayMovies("animated", movies);
                    break;

                case "2":
                    DisplayMovies("drama", movies);
                    break;

                case "3":
                    DisplayMovies("horror", movies);
                    break;

                case "4":
                    DisplayMovies("scifi", movies);
                    break;

                default:
                    Console.WriteLine("That was not a valid selection. Please try again.");
                    CategoryPick(movies);
                    break;
            }
        }

        public static void DisplayMovies(string category, List<Movie> movies)
        {
            foreach (Movie movie in movies.OrderBy(movie => movie.Title))
            {
                if (movie.Category == category)
                {
                    Console.WriteLine(movie.Title);
                }
            }
            Console.WriteLine();
        }

        public static string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            string output = Console.ReadLine().Trim().ToLower();
            Console.WriteLine();


            return output;
        }

        public static bool Continue()
        {
            string answer = GetUserInput("Continue? (y/n): ");

            if (answer.ToLower().Trim() == "y")
            {
                return true;
            }
            else if (answer.ToLower().Trim() == "n")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("Please enter either yes or no to continue.");
                return Continue();
            }

        }
    }
}
