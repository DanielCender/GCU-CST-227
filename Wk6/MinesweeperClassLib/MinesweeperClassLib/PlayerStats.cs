using System;
using System.Collections.Generic;
using System.Text;

namespace MinesweeperClassLib
{
    public class PlayerStats : IComparable<PlayerStats>
    {
        public string name { get; set;}
        // Time taken to complete game (in seconds)
        public decimal time { get; set; }

        public PlayerStats(string n, decimal t)
        {
            name = n;
            time = t;
        }

        public int CompareTo(PlayerStats other)
        {
            return time.CompareTo(time);
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", name, time);
        }
    }
}
