namespace TwoNumberSum;

public class TaskAssignment
{

    public static int[] TwoNumberSum(int[] array, int targetSum)
    {
        Dictionary<int, bool> dict = new Dictionary<int, bool>();

        foreach (var item in array)
        {
            var potentialMatch = targetSum - item;

            if (dict.ContainsKey(potentialMatch))
            {
                return new[] { item, potentialMatch };
            }

            dict[item] = true;

        }

        return new int[]{};
    }
}
