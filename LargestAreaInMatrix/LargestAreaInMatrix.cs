﻿using System;

class LargestAreaEqualNeighbourElements
{
    // bool array for optimization of recursive calls (not to call recursion if a given cell is visited)
    private static bool[,] visited;
    private static short[,] matrix;
    private static short maxCountEqualNeighbourElements = 0;
    private static short currCountEqualNeighbourElements = 0;
    private static short rows; // matrix.GetLength(0) is slow 
    private static short cols; // matrix.GetLength(1) is slow

    static void Main()
    {
        // Read the matrix dimensions
        string[] sizes = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        rows = short.Parse(sizes[0]);
        cols = short.Parse(sizes[1]);

        // Create (Allocate) the matrix
        matrix = new short[rows, cols];

        // Enter the matrix elements
        for (short row = 0; row < rows; row++) // rows = matrix.GetLength(0); matrix.GetLength(0) is slow   
        {
            string[] inputRows = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (short col = 0; col < cols; col++) //cols = matrix.GetLength(1); matrix.GetLength(1) is slow
            {
                matrix[row, col] = short.Parse(inputRows[col]);
            }
        }

        // the bool matrix
        visited = new bool[rows, cols];

        // Find the largest area of equal neighbour elements
        for (short i = 0; i < rows; i++)
        {
            for (short j = 0; j < cols; j++)
            {
                FindTheArea(i, j, matrix[i, j]);

                if (maxCountEqualNeighbourElements < currCountEqualNeighbourElements)
                {
                    maxCountEqualNeighbourElements = currCountEqualNeighbourElements;
                }

                currCountEqualNeighbourElements = 0;
            }
        }

        // Output
        Console.WriteLine(maxCountEqualNeighbourElements);
    }

    private static void FindTheArea(short row, short col, short currentElement)
    {
        //returns if we are out of the matrix or the element is not the same
        if ((row < 0) || (row >= rows)
            || (col < 0) || (col >= cols)
            || currentElement != matrix[row, col])
        {
            return;
        }

        // optimization of recursive calls (not to call recursion if a given cell is visited)
        if (visited[row, col])
        {
            return;
        }

        // Mark the current cell as visited
        visited[row, col] = true;

        currCountEqualNeighbourElements++;

        // Invoke recursion to explore all possible directions
        FindTheArea((short)(row - 1), col, currentElement); // up
        FindTheArea((short)(row + 1), col, currentElement); // down    
        FindTheArea(row, (short)(col - 1), currentElement); // left        
        FindTheArea(row, (short)(col + 1), currentElement); // right    
    }

}