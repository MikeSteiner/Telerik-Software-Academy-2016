using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Minesweeper;
using Minesweeper.PlayGround;
using Minesweeper.Writers;

namespace Minesweeper
{
    public class StartingPointAndEngine
    {
        private const int MaxScore = 35;

        public static void Main(string[] args)
        {
            string command = string.Empty;
            Fields.CreateAllFields();

            int pointsCounter = 0;
            bool flagMineExploaded = false;

            // Player alex = new Player("Alexander", 0);
            // Player todor = new Player("Todor", 0);
            // Player pesho = new Player("Peter", 0);
            // Score.players.Add(alex);
            // Score.players.Add(todor);
            // Score.players.Add(pesho);
            int row = 0;
            int col = 0;
            bool flagGameLost = true;
            bool flagGameWon = false;

            do
            {
                if (flagGameLost)
                {
                    ConsoleWriters.PrintString("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    ConsoleWriters.PrintTheField(Fields.User);

                    flagGameLost = false;
                }
                
                ConsoleWriters.PrintString("Daj red i kolona : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= Fields.User.GetLength(0) && col <= Fields.User.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        ConsoleWriters.PrintAllPlayersRanking(Score.GetAllPlayersRanking());
                        break;
                    case "restart":
                        Fields.CreateAllFields();
                        ConsoleWriters.PrintTheField(Fields.User);
                        flagMineExploaded = false;
                        flagGameLost = false;
                        break;
                    case "exit":
                        ConsoleWriters.PrintString("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (Fields.Bombs[row, col] != '*')
                        {
                            if (Fields.Bombs[row, col] == '-')
                            {
                                NextTurn(Fields.User, Fields.Bombs, row, col);
                                pointsCounter++;
                            }

                            if (MaxScore == pointsCounter)
                            {
                                flagGameWon = true;
                            }
                            else
                            {
                                ConsoleWriters.PrintTheField(Fields.User);
                            }
                        }
                        else
                        {
                            flagMineExploaded = true;
                        }

                        break;
                    default:
                        ConsoleWriters.PrintString("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (flagMineExploaded)
                {
                    ConsoleWriters.PrintTheField(Fields.Bombs);
                    string tempString = string.Format("\nHrrrrrr! Umria gerojski s {0} to4ki. Daj si niknejm: ", pointsCounter);
                    ConsoleWriters.PrintString(tempString);

                    string nickName = Console.ReadLine();
                    Player playerToBeAddedToScoreResults = new Player(nickName, pointsCounter);

                    if (Score.Players.Count < 5)
                    {
                        Score.Players.Add(playerToBeAddedToScoreResults);
                    }
                    else
                    {
                        for (int i = 0; i < Score.Players.Count; i++)
                        {
                            if (Score.Players[i].Points < playerToBeAddedToScoreResults.Points)
                            {
                                Score.Players.Insert(i, playerToBeAddedToScoreResults);
                                Score.Players.RemoveAt(Score.Players.Count - 1);

                                break;
                            }
                        }
                    }

                    Score.Players.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
                    Score.Players.Sort((Player r1, Player r2) => r2.Points.CompareTo(r1.Points));
                    ConsoleWriters.PrintAllPlayersRanking(Score.GetAllPlayersRanking());

                    Fields.CreateAllFields();
                    pointsCounter = 0;
                    flagMineExploaded = false;
                    flagGameLost = true;
                }

                if (flagGameWon)
                {
                    ConsoleWriters.PrintString("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    ConsoleWriters.PrintTheField(Fields.Bombs);
                    ConsoleWriters.PrintString("Daj si imeto, batka: ");

                    string nickName = Console.ReadLine();
                    Player to4kii = new Player(nickName, pointsCounter);
                    Score.Players.Add(to4kii);

                    ConsoleWriters.PrintAllPlayersRanking(Score.GetAllPlayersRanking());

                    Fields.CreateAllFields();
                    pointsCounter = 0;
                    flagGameWon = false;
                    flagGameLost = true;
                }
            }
            while (command != "exit");

            ConsoleWriters.PrintOnExitMessage();
        }

        private static void NextTurn(char[,] userField, char[,] bombsField, int row, int col)
        {
            char symbolFromBombsField = GetSymbolFromField(bombsField, row, col);
            bombsField[row, col] = symbolFromBombsField;
            userField[row, col] = symbolFromBombsField;
        }

        // TODO this method is not used
        private static void NotUsedCalculations(char[,] pole)
        {
            int kol = pole.GetLength(0);
            int red = pole.GetLength(1);

            for (int i = 0; i < kol; i++)
            {
                for (int j = 0; j < red; j++)
                {
                    if (pole[i, j] != '*')
                    {
                        char symbolFromField = GetSymbolFromField(pole, i, j);
                        pole[i, j] = symbolFromField;
                    }
                }
            }
        }

        private static char GetSymbolFromField(char[,] field, int currentRow, int currentCol)
        {
            int pointsCouter = 0;
            int maxRows = field.GetLength(0);
            int maxCols = field.GetLength(1);

            if (currentRow - 1 >= 0)
            {
                if (field[currentRow - 1, currentCol] == '*')
                {
                    pointsCouter++;
                }
            }

            if (currentRow + 1 < maxRows)
            {
                if (field[currentRow + 1, currentCol] == '*')
                {
                    pointsCouter++;
                }
            }

            if (currentCol - 1 >= 0)
            {
                if (field[currentRow, currentCol - 1] == '*')
                {
                    pointsCouter++;
                }
            }

            if (currentCol + 1 < maxCols)
            {
                if (field[currentRow, currentCol + 1] == '*')
                {
                    pointsCouter++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentCol - 1 >= 0))
            {
                if (field[currentRow - 1, currentCol - 1] == '*')
                {
                    pointsCouter++;
                }
            }

            if ((currentRow - 1 >= 0) && (currentCol + 1 < maxCols))
            {
                if (field[currentRow - 1, currentCol + 1] == '*')
                {
                    pointsCouter++;
                }
            }

            if ((currentRow + 1 < maxRows) && (currentCol - 1 >= 0))
            {
                if (field[currentRow + 1, currentCol - 1] == '*')
                {
                    pointsCouter++;
                }
            }

            if ((currentRow + 1 < maxRows) && (currentCol + 1 < maxCols))
            {
                if (field[currentRow + 1, currentCol + 1] == '*')
                {
                    pointsCouter++;
                }
            }

            return char.Parse(pointsCouter.ToString());
        }
    }
}
