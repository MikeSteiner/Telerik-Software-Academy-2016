using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public static class Score
    {
        public static List<Player> Players = new List<Player>();
        
        public static string GetAllPlayersRanking()
        {
            if (Players.Count <= 0)
            {
                string msg = "Empty players collection!";
                throw new InvalidOperationException(msg);                              
            }

            StringBuilder sbToPrint = new StringBuilder();

            for (int i = 0; i < Players.Count; i++)
            {
                sbToPrint.Append(string.Format("{0}. ", i + 1));
                sbToPrint.Append(Players[i].PrintNameAndPoints());
                sbToPrint.AppendLine();
            }

            sbToPrint.AppendLine();

            return sbToPrint.ToString();
        }        
    }
}