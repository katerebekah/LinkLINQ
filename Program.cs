using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQLink
{
    class Program
    {

        static void Main(string[] args)
        {
            var legendOfZeldaGames = LinkBuilder.Games;

            // foreach (var game in legendOfZeldaGames){
            //     Log(game);
            // }

            // legendOfZeldaGames.ForEach(game => Log(game));

            /**
             * Any, All
             */
            //Do any of the games for the DS have more than 8 boss fights?
            var anyDSFights = legendOfZeldaGames.Any(game => game.OriginalConsole == ConsoleEnum.NintendoDS && game.BossFights > 8);

            //Do all the Legend of Zelda games have "Link" in the title?
            var allLinks = legendOfZeldaGames.All(game => game.Name.Contains("Link"));
            /**
             * Count, Sum, Average
             */

            // How many Legend of Zelda Games have been made?
            var count1 = legendOfZeldaGames.Count();
            // How many boss fights are there in all of the games?
            var sum = legendOfZeldaGames.Sum(game => game.BossFights);
            // What is the average number of boss fights per game
            var ave = legendOfZeldaGames.Average(game => game.BossFights);


            var i = 0;

            foreach (var game in legendOfZeldaGames){
                i += game.BossFights;
            }

            var average = i/count1;



            /**
             * Max / Max
             */

            // Which game had the most boss fights?
            var mxfights = legendOfZeldaGames.Max(game => game.BossFights);
            // Which game had the fewest boss fights? 
            var mnfights = legendOfZeldaGames.Min(game => game.BossFights);
            /**
             * OrderBy
             */

            // Sort the games in alphabetical order. 
            var orderedGames = legendOfZeldaGames.OrderBy(game => game.Name);
            
            /**
             * Where
             */
            /**
             * Select / SelectMany
             */

            //Which Legend of Zelda games were created before 30 years ago?
            var thirty = 
            //get your data source
            from game in legendOfZeldaGames
            //create your query
            where game.ReleaseYear < 1988
            && game.BossFights > 10 
            && game.OriginalConsole == ConsoleEnum.NintendoEntertainmentSystem
            //execute your query
            select $"{game.Name} has {game.BossFights} boss fights - good luck!";
            
            //Console.WriteLine("thirty:");
            //thirty.ToList().ForEach(x => Log(x));

            var thirty2 = legendOfZeldaGames
                .Where(game => game.BossFights > 10)
                .Where(game => game.OriginalConsole == ConsoleEnum.NintendoEntertainmentSystem)
                .Where(game => game.ReleaseYear < 1988)
                .Select(game => game.Name)
                .ToList(); 
            
            /**
             * First / FirstOrDefault, Last / LastOrDefault, Single / SingleOrDefault
             */

            // What was the first game released in the 2000s?
            var game1 = legendOfZeldaGames
                .OrderBy(game => game.ReleaseYear)
                .FirstOrDefault(game => game.ReleaseYear > 1999 && game.ReleaseYear < 2010);

            //If any, what game was released in 2002?
            var game2 = legendOfZeldaGames.FirstOrDefault(game => game.ReleaseYear == 2002);

            /**
             * Group By
             */

            // Group the games by the console.

            var gamesByConsole = legendOfZeldaGames.GroupBy(x => x.OriginalConsole);

            // foreach( var g in gamesByConsole){
            //     Log(g);
            // }

            /**
             * Distinct
             */

            // Log the distinct (not repeated) consoles for all of the games.
            var distinctConsoles = legendOfZeldaGames.Select(x => x.OriginalConsole).Distinct();


            /**
             * Joins
             */
            var gamers = LinkBuilder.Gamers;

            //for each gamer, print the gamer's name, their favorite game's title and release date
            var join =             
            from gamer in gamers
            join game in legendOfZeldaGames
                on gamer.FavoriteGame equals game.Name
            select $"{gamer.Name} - {gamer.FavoriteGame}, {game.ReleaseYear}"; 
        }

        private static void Log(Game game){
            Console.WriteLine($"{game.Name} - {game.ReleaseYear} - {game.OriginalConsole.ToString()}");
        }
        private static void Log(string message){
            Console.WriteLine(message);
        }
        private static void Log(IGrouping<ConsoleEnum, Game> message){
            Console.WriteLine($"{message.Key.ToString()} - {message.Select(x => x.Name + " ~")}");
        }
    }
}
