/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        if (root == null)
        {
            return new List<int>();
        }
        IList<int> Result;
        Result = PostorderTraversal(root.left).Concat(PostorderTraversal(root.right)).ToList();
        Result.Add(root.val);
        return Result;  
    }
}