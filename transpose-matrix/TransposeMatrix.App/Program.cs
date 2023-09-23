// See https://aka.ms/new-console-template for more information

using TransposeMatrix.App;

Console.WriteLine("Transpose2DMatrix Algorithm");

var array2D = new int[2, 2];
array2D[0, 0] = 1;
array2D[0, 1] = 2;
array2D[1, 0] = 3;
array2D[1, 1] = 4;


Console.WriteLine("Before transpose");

for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        Console.Write(array2D[i, j] + "\t");  // Display element and add a tab space
    }
    
    Console.WriteLine();  // New line after each row
}

var algorithm = new TransposeMatrixAlgorithm();

array2D = algorithm.TransposeMatrix(array2D);


Console.WriteLine("After transpose");
// Display the 2D array as a matrix
for (int i = 0; i < array2D.GetLength(0); i++)  // Iterate over rows
{
    for (int j = 0; j < array2D.GetLength(1); j++)  // Iterate over columns
    {
        Console.Write(array2D[i, j] + "\t");  // Display element and add a tab space
    }
    Console.WriteLine();  // New line after each row
}