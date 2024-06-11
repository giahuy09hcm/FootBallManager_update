using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBallManager
{
    public class PlayerInfo
    {
        public string Name { get; set; }
        public Point Location { get; set; }
        public string ImagePath { get; set; }
        public float Score { get; set; }

        public PlayerInfo(string name, Point location, string imagePath, float score)
        {
            Name = name;
            Location = location;
            ImagePath = imagePath;
            Score = score;
        }
    }
}
