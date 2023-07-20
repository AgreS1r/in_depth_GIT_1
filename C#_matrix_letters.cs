static char[,] FillSpiralMatrix(int n)
{
    char[,] matrix = new char[n, n];
    int rowStart = 0, rowEnd = n - 1, colStart = 0, colEnd = n - 1;
    int num = 0;
    char letter = 'A';
    while (rowStart <= rowEnd && colStart <= colEnd)
    {

        for (int i = colStart; i <= colEnd; i++)
        {
            matrix[rowStart, i] = letter;
            letter = (char)('A' + ((num++) % 26));
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            matrix[i, colEnd] = letter;
            letter = (char)('A' + ((num++) % 26));
        }
        colEnd--;

        if (rowStart <= rowEnd)
        {
            for (int i = colEnd; i >= colStart; i--)
            {
                matrix[rowEnd, i] = letter;
                letter = (char)('A' + ((num++) % 26));
            }
            rowEnd--;
        }

        if (colStart <= colEnd)
        {
            for (int i = rowEnd; i >= rowStart; i--)
            {
                matrix[i, colStart] = letter;
                letter = (char)('A' + ((num++) % 26));
            }
            colStart++;
        }
    }
    return matrix;
}
