using BranchSums.App;

Console.WriteLine("Branch Sums");

var binaryTree = new BinaryTree(20)
{
    Left = new BinaryTree(10),
    Right = new BinaryTree(30)
};

var result = BranchSumsAlgorithm.BranchSums(binaryTree);


foreach (var sumItem in result)
{
    Console.WriteLine(sumItem);
}

