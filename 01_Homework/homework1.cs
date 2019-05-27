using System;

//homework 1 in c#: by Raya Hazi

namespace homeworkLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 3;
            string[][] matrix = new string[size][];
            
            for(int row = 0; row < matrix.Length; row++)
            {
                for(int col = 0; col < matrix.Length; col++)
                {
                    if (row == col)                    
                        matrix[row][col] = "main";
                    else if (row + col == size - 1)
                        matrix[row][col] = "sub";
                    else if (col > row)
                        matrix[row][col] = "up";
                    else if (row > col)
                        matrix[row][col] = "down";                                        
                    else if (row == size-2 && col == size-2)
                        matrix[row][col] = "center";                   
                }
            }

            foreach(string[] row in matrix)
            {
                foreach(string col in row)
                {
                    Console.WriteLine(row);
                }
            }
        }
    }
}
