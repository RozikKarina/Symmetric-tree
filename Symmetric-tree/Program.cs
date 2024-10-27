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
public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        // Base case: if root is null, it's symmetric
        if (root == null) return true;

        // Check if left and right subtrees are mirrors
        return IsMirror(root.left, root.right);
    }

    private bool IsMirror(TreeNode left, TreeNode right)
    {
        // Base case: if both subtrees are null, they are symmetric
        if (left == null && right == null) return true;

        // If one subtree is null, or values are not the same, not symmetric
        if (left == null || right == null || left.val != right.val) return false;

        // Recursively check for mirror symmetry
        return IsMirror(left.left, right.right) && IsMirror(left.right, right.left);
    }
}