using System.Collections.Generic;

namespace LINQLink
{
    public static class LinkBuilder
    {
        public static List<Game> Games { get; } = new List<Game> {
            new Game {
                Name = "The Legend of Zelda",
                ReleaseYear = 1986,
                OriginalConsole = ConsoleEnum.NintendoEntertainmentSystem,
                BossFights = 7
            },
            new Game {
                Name = "The Adventure of Link",
                ReleaseYear = 1987,
                OriginalConsole = ConsoleEnum.NintendoEntertainmentSystem,
                BossFights = 8
            },
            new Game {
                Name = "A Link to the Past",
                ReleaseYear = 1991,
                OriginalConsole = ConsoleEnum.SuperNES,
                BossFights = 12
            },
            new Game {
                Name = "Link's Awakening",
                ReleaseYear = 1993,
                OriginalConsole = ConsoleEnum.GameBoy,
                BossFights = 9
            },
            new Game {
                Name = "Ocarina of Time",
                ReleaseYear = 1998,
                OriginalConsole = ConsoleEnum.Nintendo64,
                BossFights = 10
            },
            new Game {
                Name = "Majora's Mask",
                ReleaseYear = 2000,
                OriginalConsole = ConsoleEnum.Nintendo64,
                BossFights = 5
            },
            new Game {
                Name = "Oracle of Seasons and Oracle of Ages",
                ReleaseYear = 2001,
                OriginalConsole = ConsoleEnum.GameBoyColor,
                BossFights = 21
            },
            new Game {
                Name = "Four Swords Adventures",
                ReleaseYear = 2002,
                OriginalConsole = ConsoleEnum.GameCube,
                BossFights = 10
            },
            new Game {
                Name = "The Minnish Cap",
                ReleaseYear = 2002,
                OriginalConsole = ConsoleEnum.GameBoyAdvance,
                BossFights = 6
            },
            new Game {
                Name = "Twilight Princess",
                ReleaseYear = 2006,
                OriginalConsole = ConsoleEnum.Wii,
                BossFights = 12
            },
            new Game {
                Name = "Phantom Hourglass",
                ReleaseYear = 2007,
                OriginalConsole = ConsoleEnum.NintendoDS,
                BossFights = 10
            },
            new Game {
                Name = "Spirit Tracks",
                ReleaseYear = 2009,
                OriginalConsole = ConsoleEnum.NintendoDS,
                BossFights = 9
            },
            new Game {
                Name = "Skyward Sword",
                ReleaseYear = 2011,
                OriginalConsole = ConsoleEnum.Wii,
                BossFights = 8
            },
            new Game {
                Name = "A Link Between Worlds",
                ReleaseYear = 2013,
                OriginalConsole = ConsoleEnum.Nintendo3DS,
                BossFights = 11
            },
            new Game {
                Name = "Tri Force Heroes",
                ReleaseYear = 2015,
                OriginalConsole = ConsoleEnum.Nintendo3DS,
                BossFights = 8
            },
            new Game {
                Name = "Breath of the Wild",
                ReleaseYear = 2017,
                OriginalConsole = ConsoleEnum.NintendoSwitch,
                BossFights = 10
            }
        };
    }
}