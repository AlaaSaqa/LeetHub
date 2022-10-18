/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            var pPath = FindPath(root, p);
            var qPath = FindPath(root, q);
            pPath.Reverse();
            qPath.Reverse();
            int i = 0;

            for (i = 0; i < pPath.Count && i < qPath.Count; i++)
            {
                if (pPath[i].val != qPath[i].val)
                {
                    return new TreeNode(pPath[i-1].val, pPath[i-1].left, pPath[i-1].right);
                }
            }
            return new TreeNode(pPath[Math.Min(pPath.Count,qPath.Count)-1].val);
        }
        public  List<TreeNode> FindPath(TreeNode root, TreeNode p) {
            if (p == null || root==null)
            {
                return new List<TreeNode>();
            }
            if (root.val == p.val)
            {
                return new List<TreeNode>()
                {
                    new TreeNode(root.val, root.left, root.right)
                };
            }

            var RightList = FindPath(root.right, p);
            var LeftList = FindPath(root.left, p);

            if (RightList.Count != 0)
            {
                RightList.Add(root);
                return RightList;
            }
            if (LeftList.Count != 0)
            {
                LeftList.Add(root);
                return LeftList;
            }

            return new List<TreeNode>();
        }
}