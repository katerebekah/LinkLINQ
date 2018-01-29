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

            foreach (var game in legendOfZeldaGames){
                Log(game);
            }

            legendOfZeldaGames.ForEach(game => Log(game));

            /**
             * Any, All
             */

            //Were any of the Legend of Zelda games created in the past 30 years?
            
            //Do all the Legend of Zelda games have "Link" in the title?
            
            /**
             * Count, Sum, Average
             */

            // How many Legend of Zelda Games have been made?
            
            // How many boss fights are there in all of the games?

            // What is the average number of boss fights per car

            /**
             * Max / Max
             */

            // Which game had the most boss fights?

            // Which game had the fewest boss fights? 
            
            /**
             * OrderBy
             */

            // Sort the games in alphabetical order. 
            
            /**
             * Where
             */

            // Find which games were made in the 1990s 
            
            /**
             * Select / SelectMany
             */

            // Only log the title of the games

            //
            
            /**
             * First / FirstOrDefault, Last / LastOrDefault, Single / SingleOrDefault
             */
            // 
            
            /**
             * Group By
             */
             
            // Group the games by the console.


            /**
             * Distinct
             */
            // Log the distinct (not repeated) consoles for all of the games.

            /**
             * Join
             */
            // 
        }

        private static void Log(Game game){
            Console.WriteLine($"{game.Name} - {game.ReleaseYear} - {game.OriginalConsole.ToString()}");
        }
        private static void Log(string message){
            Console.WriteLine(message);
        }
        private static void Log(IGrouping<ConsoleEnum, Game> message){
            Console.WriteLine($"{message.Key.ToString()} - {message.Select(x => x.Name)}");
        }
    }
}
