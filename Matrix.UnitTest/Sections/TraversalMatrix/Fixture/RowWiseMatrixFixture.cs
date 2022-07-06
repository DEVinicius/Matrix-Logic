namespace Matrix.UnitTest.Sections.TraversalMatrix.Fixture;

public class RowWiseMatrixFixture
{
    public static int[,] GetIntMatrix()
    {
        return new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
    }
    
    public static int[,] GetNotSquareIntMatrix()
    {
        return new int[,] { { 1, 2, 3 }, { 4, 5, 0 }, { 6, 0, 0 }, { 6, 0, 0 } };
    }

    public static int[] RowWiseResponse()
    {
        return new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    }
}