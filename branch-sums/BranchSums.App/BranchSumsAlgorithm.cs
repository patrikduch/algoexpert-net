namespace BranchSums.App;

public static class BranchSumsAlgorithm
{
    public static List<int> BranchSums(BinaryTree? root) {  
        var result = new List<int>();
        CalculateBranchSum(root, 0, result);
        return result;
    }
    
    private static void CalculateBranchSum(BinaryTree? root, int sum, ICollection<int> sums)
    {
        if (root == null)
        {
            return;
        }

        var currentSum = root.Value + sum;

        if (root?.Left == null && root?.Right == null)
        {
            sums.Add(currentSum);
            return;
        }
        
        CalculateBranchSum(root.Left, currentSum, sums);
        CalculateBranchSum(root.Right, currentSum, sums);
    }
}