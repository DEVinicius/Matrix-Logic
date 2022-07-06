namespace Matrix.Application.Sections;

public class TraversalMatrix<T>
{
    public T[,] Matrix { get; private set; }

    public TraversalMatrix(T[,] matrix)
    {
        Matrix = matrix;
    }

    public T[] GetRowWise()
    {
        IsSquareMatrix();
        T[] data = new T[Matrix.GetLength(0) * Matrix.GetLength(1)];

        for (int row = 0; row < Matrix.GetLength(0); row++)
        {
            for (int column = 0; column < Matrix.GetLength(0); column++)
            {
                data[3 * row + column] = Matrix[row,column];
            }
        }
    
        return data;
    }

    private void IsSquareMatrix()
    {
        if (Matrix.GetLength(0) != Matrix.GetLength(1))
            throw new Exception("Matrix arent Square");
    }
}