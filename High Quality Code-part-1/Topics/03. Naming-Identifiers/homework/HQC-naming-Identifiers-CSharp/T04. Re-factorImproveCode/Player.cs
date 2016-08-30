using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class Player
    {
        private string name;
        private int points;

        public Player()
        {
            this.Name = string.Empty;
            this.Points = 0;
        }

        public Player(string name)
        {
            this.name = name;
            this.Points = 0;
        }

        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public int Points
        {
            get
            {
                return this.points;
            }

            set
            {
                this.points = value;
            }
        }

        public string PrintNameAndPoints()
        {
            string nameAndPoints = string.Format("{0} --> {1} points", this.Name, this.points);

            return nameAndPoints;
        }
    }
}
