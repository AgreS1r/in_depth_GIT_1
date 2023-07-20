static int[,] FillSpiralMatrix(int n)
{
    int[,] matrix = new int[n, n];
    int rowStart = 0, rowEnd = n - 1, colStart = 0, colEnd = n - 1;
    int num = 1;
    while (rowStart <= rowEnd && colStart <= colEnd)
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            matrix[rowStart, i] = num;
            num++;
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            matrix[i, colEnd] = num;
            num++;
        }
        colEnd--;

        if (rowStart <= rowEnd)
        {
            for (int i = colEnd; i >= colStart; i--)
            {
                matrix[rowEnd, i] = num;
                num++;
            }
            rowEnd--;
        }

        if (colStart <= colEnd)
        {
            for (int i = rowEnd; i >= rowStart; i--)
            {
                matrix[i, colStart] = num;
                num++;
            }
            colStart++;
        }
    }
    return matrix;
}
