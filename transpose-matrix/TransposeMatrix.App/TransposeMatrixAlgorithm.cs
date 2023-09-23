namespace TransposeMatrix.App;

public class TransposeMatrixAlgorithm
{
    public int[,] TransposeMatrix(int[,] matrix)
    {
        var rows = matrix.GetLength(0);
        var columns = matrix.GetLength(1);

        var transposeMatrix = new int[columns, rows];
        
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                transposeMatrix[j, i] = matrix[i,j];
            }
        }


        return transposeMatrix;
    }
}
