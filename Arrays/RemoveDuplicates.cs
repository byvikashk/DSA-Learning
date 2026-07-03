// Remove duplicates from an array using HashSet


public class RemoveDuplicates
{
    static void Main(String [] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5 };
        HashSet<int> set = new HashSet<int>(arr);
        foreach (var i in set)
        {
            Console.Write(i + " ");
        }
        //time complexity is O(n) and space complexity is O(n)
    }
}