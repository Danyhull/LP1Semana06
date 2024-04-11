using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;


namespace PlayerStats
{
    public class Player
    {
        private float highScore;
        private int playedGames;
        private int wonGames

        public float highScore
        {
            get { return highScore; }
        }
        set
        {
            if (highScore < value)
            {
                highScore = value;
            }
        }
    }

    public void PlayGame(bool win)
    {
        playedGames += 1;
        if (win)
        {
            wonGames += 1;
        }
    }
    public Player (string name)
    {
        Name = name;
        highScore = 0;
        playedGames = 0;
        wonGames = 0;
    }
}
