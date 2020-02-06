using System;
using System.Collections.Generic;

namespace Lab_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> ListOfMovies = new List<Movie>()
            {
                new ScifiMovie("2001: A Space Odyssey"),
                new ScifiMovie("E.T. The Extra-terrestrial"),
                new ScifiMovie("Star Wars"),
                new ScifiMovie("A Clockwork Orange"),
                new ScifiMovie("Close Enounters of the Third Kind"),

                new DramaMovie("Hidden Figures"),
                new DramaMovie("Selma"),
                new DramaMovie("The Perks of Being a Wallflower "),
                new DramaMovie("The Fault in Our Stars "),
                new DramaMovie("The Help"),

                new AnimatedMovie("Frozen"),
                new AnimatedMovie("Zootopia"),
                new AnimatedMovie("Inside Out"),
                new AnimatedMovie("Mulan"),
                new AnimatedMovie("Finding Nemo"),

                new HorrorMovie("The Shining"),
                new HorrorMovie("The Exorcist"),
                new HorrorMovie("Get Out"),
                new HorrorMovie("Us"),
                new HorrorMovie("Friday the 13th"),

            };

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 25 movies in this list.");

            
            string userCategory;
            do
            {
                Console.Write("\nWhat category would you be interested in? (animated, drama, horror, or scifi) ");
                userCategory = Console.ReadLine();

                if (userCategory.Equals("animated", StringComparison.OrdinalIgnoreCase) ||
                    userCategory.Equals("drama", StringComparison.OrdinalIgnoreCase) ||
                    userCategory.Equals("horror", StringComparison.OrdinalIgnoreCase) ||
                    userCategory.Equals("scifi", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine();
                    foreach (var movie in ListOfMovies)
                    {
                        if (movie.Category.Contains(userCategory))
                        {
                            Console.WriteLine(movie);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nCategory does not exist in the list");
                }
            } while (UserContinue());

            Console.WriteLine();
            Console.WriteLine("\nGoodbye!");
        }
        static bool UserContinue()
        {
            char key;
            do
            {
                Console.Write("\nContinue? (y/n) ");
                key = Console.ReadKey().KeyChar;
                key = char.ToLower(key);
                if (key == 'n')
                {
                    return false;
                }
                Console.WriteLine();

            } while (key != 'y');
            return true;
        }
        
    }
}
