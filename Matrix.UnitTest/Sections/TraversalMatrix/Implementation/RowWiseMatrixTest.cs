using System;
using System.Threading.Tasks;
using FluentAssertions;
using Matrix.Application.Sections;
using Matrix.UnitTest.Sections.TraversalMatrix.Fixture;
using Xunit;

namespace Matrix.UnitTest.Sections.TraversalMatrix.Implementation;

public class RowWiseMatrixTest
{
    [Fact]
    public void OnSuccess_ReturnAnArray()
    {
        var traversalMatrixTest = new TraversalMatrix<int>(RowWiseMatrixFixture.GetIntMatrix());

        traversalMatrixTest.GetRowWise().Should().BeOfType<int[]>();
    }

    [Fact]
    public void OnFail_CheckIsSquareMatrix()
    {
        var traversalMatrixTest = new TraversalMatrix<int>(RowWiseMatrixFixture.GetNotSquareIntMatrix());

        Assert.Throws<Exception>(() => traversalMatrixTest.GetRowWise());
    }

    [Fact]
    public void OnSuccess_ReturnCorrectFixture()
    {
        var traversalMatrixTest = new TraversalMatrix<int>(RowWiseMatrixFixture.GetIntMatrix());

        var rowWiseArray = traversalMatrixTest.GetRowWise();

        for (var i = 0; i < rowWiseArray.Length; i++)
            rowWiseArray[i].Should().BeGreaterThanOrEqualTo(RowWiseMatrixFixture.RowWiseResponse()[i]);
    }
}