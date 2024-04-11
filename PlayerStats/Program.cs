﻿using System;

namespace PlayerStats
{
    public class Program
    {
        private static void Main()
        {
            Player[] players = {
                new Player("Ana"),
                new Player("Zé"),
                new Player("Doesn't play")
            };

            players[0].PlayGame(false);
            players[0].PlayGame(true);
            players[0].PlayGame(true);
            players[0].PlayGame(false);
            players[0].PlayGame(false);
            players[0].PlayGame(true);
            players[0].HighScore = 101;
            players[0].HighScore = 40;

            players[1].PlayGame(true);
            players[1].PlayGame(true);
            players[1].HighScore = 12;
            players[1].HighScore = 67;
            players[1].HighScore = 99;
            players[1].HighScore = 32;

            foreach (Player player in players)
            {
                Console.WriteLine($" Player name : {player.Name}");
                Console.WriteLine($"    Win rate : {player.WinRate}");
                Console.WriteLine($"  High score : {player.HighScore}");
                Console.WriteLine("--------------------------------");
            }

            // Output deverá de ser:
            //
            //  Player name : Lurdes
            //     Win rate : 0.5
            //   High score : 101
            // --------------------------------
            //  Player name : Carlos
            //     Win rate : 1
            //   High score : 99
            // --------------------------------
            //  Player name : Doesn't play
            //     Win rate : 0
            //   High score : 0
            // --------------------------------

        }
    }
}