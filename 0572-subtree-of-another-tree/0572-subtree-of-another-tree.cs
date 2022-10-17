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
     public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(subRoot==null){
            return true;
        }
        if(root==null){
            return false;
        }
        if (IsIdentical(root, subRoot)){
            return true;
        }
        return IsSubtree(root.left,subRoot)||IsSubtree(root.right,subRoot);
    }
    public bool IsIdentical(TreeNode root, TreeNode subRoot) {
        if (root==null&&subRoot==null){
            return true;
        }
        if(subRoot==null || root == null){
            return false;
        }
        return root.val==subRoot.val &&
        IsIdentical(root.right,subRoot.right) && 
        IsIdentical(root.left,subRoot.left);
        
    }
}