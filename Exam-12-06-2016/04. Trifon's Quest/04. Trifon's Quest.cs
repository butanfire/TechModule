namespace TrifonQuest
{
    using System;
    using System.Linq;

    public class TrifonQuest
    {
        static void Main(string[] args)
        {
            var healthPoints = long.Parse(Console.ReadLine());
            var size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rows = size[0];
            var cols = size[1];

            int turns = 0;

            char[][] matrix = new char[rows][]; //jagged array easier for assignment
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }

            bool endGame = false;
            for (int j = 0; j < cols && !endGame; j++) //snake-like movement in the matrix, going through the rows as cols.
            {
                if (j % 2 == 0)
                    for (int i = 0; i < rows && !endGame; i++)
                    {
                        endGame = ProcessTurn(matrix, i, j, ref healthPoints, ref turns);
                    }
                else
                {
                    for (int i = rows - 1; i >= 0 && !endGame; i--)
                    {
                        endGame = ProcessTurn(matrix, i, j, ref healthPoints, ref turns);
                    }
                }
            }

            if (healthPoints > 0)
            {
                Console.WriteLine("Quest completed!");
                Console.WriteLine("Health: {0}\nTurns: {1}", healthPoints, turns);
            }
        }

        private static bool ProcessTurn(char[][] matrix, int col, int row, ref long healthPoints, ref int turns)
        {
            switch (matrix[col][row]) //process each field
            {
                case 'F':
                    healthPoints -= turns / 2;
                    break;
                case 'H':
                    healthPoints += turns / 3;
                    break;
                case 'T':
                    turns += 2;
                    break;
                case 'E':
                    break;
            }

            turns++; //increase turns after each action/field

            if (healthPoints <= 0)
            {
                Console.WriteLine("Died at: [{0}, {1}]", col, row);
                return true;
            }

            return false;
        }
    }
}
