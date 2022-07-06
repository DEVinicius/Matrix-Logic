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
                data[(3 * row) + column] = Matrix[row,column];
            }
        }
    
        return data;
    }

    public T[] GetColumnWise()
    {
        IsSquareMatrix();
        T[] data = new T[Matrix.GetLength(0) * Matrix.GetLength(1)];

        for (int row = 0; row < Matrix.GetLength(0); row++)
        {
            for (int column = 0; column < Matrix.GetLength(0); column++)
            {
                data[row + (3 * column)] = Matrix[row,column];
            }
        }
    
        return data;
    }

    public T[] GetSpiral()
    {
        IsSquareMatrix();
        var MatrixLineLength = Matrix.GetLength(0);
        
        var column = MatrixLineLength;
        var row = MatrixLineLength;

        var condition = MatrixLineLength % 2 == 0
            ? ((row == (MatrixLineLength / 2)) && (column == ((MatrixLineLength / 2) - 1))) : ((row == (MatrixLineLength / 2)) && (column == ((MatrixLineLength / 2))));

        do
        {
            column = column - 1;
        } while (
            MatrixLineLength % 2 == 0 
                ? ((row == MatrixLineLength / 2) && (column == ((MatrixLineLength / 2) - 1))) 
                : ((row == (MatrixLineLength / 2)) && (column == ((MatrixLineLength / 2))))    
        );
    }

    private void IsSquareMatrix()
    {
        if (Matrix.GetLength(0) != Matrix.GetLength(1))
            throw new Exception("Matrix arent Square");
    }
}