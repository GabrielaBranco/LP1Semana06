using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        public string Name { get; private set; }
        private float highScore;
        private int playedGames;
        private int wonGames;

        public float WinRate
        {
            get
            {
                if(playedGames > 0)
                {
                    return (float)wonGames/playedGames;
                }
                return 0;
            }
        }

        public float HighScore
        { 
            get
            {
                return highScore;
            }
            set
            {
                if(value > highScore)
                {
                    highScore = value;
                }
            } 
        }

        public Player(string name)
        {
            Name = name;
        }

        public void PlayGame(bool win)
        {
            playedGames++;
            if(win)
            {
                wonGames++;
                HighScore++;
            }
        }
    }
}