using System;
using FluentAssertions;
using Matrix.Application.Sections;
using Matrix.UnitTest.Sections.TraversalMatrix.Fixture;
using Xunit;

namespace Matrix.UnitTest.Sections.TraversalMatrix.Implementation;

public class ColumnWiseMatrixTest
{
    [Fact]
    public void OnSuccess_ReturnAnArray()
    {
        var traversalMatrixTest = new TraversalMatrix<int>(ColumnWiseMatrixFixture.GetIntMatrix());

        traversalMatrixTest.GetColumnWise().Should().BeOfType<int[]>();
    }

    [Fact]
    public void OnFail_CheckIsSquareMatrix()
    {
        var traversalMatrixTest = new TraversalMatrix<int>(ColumnWiseMatrixFixture.GetNotSquareIntMatrix());

        Assert.Throws<Exception>(() => traversalMatrixTest.GetColumnWise());
    }

    [Fact]
    public void OnSuccess_ReturnCorrectFixture()
    {
        var traversalMatrixTest = new TraversalMatrix<int>(ColumnWiseMatrixFixture.GetIntMatrix());

        var rowWiseArray = traversalMatrixTest.GetColumnWise();

        for (var i = 0; i < rowWiseArray.Length; i++)
            rowWiseArray[i].Should().BeGreaterThanOrEqualTo(ColumnWiseMatrixFixture.ColumnWiseResponse()[i]);
    }
}