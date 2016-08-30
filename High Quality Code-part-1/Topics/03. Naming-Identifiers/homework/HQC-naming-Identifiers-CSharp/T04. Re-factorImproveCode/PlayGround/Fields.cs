using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper.PlayGround
{
    public static class Fields
    {
        public const int Rows = 5;
        public const int Cols = 10;
        public const int BombsOnTheFieldCount = 15;

        public static char[,] Bombs { get; private set; }

        public static char[,] User { get; private set; }

        public static void CreateAllFields()
        {
            User = CreateEmptyFieldOfSymbols('?');
            Bombs = CreateBackgroundRealField();
        }

        private static char[,] CreateEmptyFieldOfSymbols(char symbol)
        {            
            char[,] field = new char[Rows, Cols];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    field[i, j] = symbol;
                }
            }

            return field;
        }
        
        private static List<int> GenerateRandomBombsPositions(int howMuchBombsToPutOnField)
        {
            List<int> bombsPositions = new List<int>();
            while (bombsPositions.Count < howMuchBombsToPutOnField)
            {
                Random random = new Random();
                int nextBombPosition = random.Next(50);
                if (!bombsPositions.Contains(nextBombPosition))
                {
                    bombsPositions.Add(nextBombPosition);
                }
            }

            return bombsPositions;
        }

        private static char[,] CreateBackgroundRealField()
        {
            char[,] backgroundField = CreateEmptyFieldOfSymbols('-');
            List<int> bombsPositions = GenerateRandomBombsPositions(BombsOnTheFieldCount);
            
            foreach (int bomobPosition in bombsPositions)
            {
                int bombCol = bomobPosition / Cols;
                int bombRow = bomobPosition % Cols;

                if (bombRow == 0 && bomobPosition != 0)
                {
                    bombCol--;
                    bombRow = Cols;
                }
                else
                {
                    bombRow++;
                }

                backgroundField[bombCol, bombRow - 1] = '*';
            }

            return backgroundField;
        }       
    }
}
