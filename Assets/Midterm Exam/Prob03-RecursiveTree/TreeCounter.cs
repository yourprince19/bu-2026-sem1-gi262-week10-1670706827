using System;

namespace MidtermExam.Prob03
{
    public class TreeCounter
    {
        public int AS03_CountTotalNode(Node root)
        {
            if (root == null) return 0;
            return 1 + AS03_CountTotalNode(root.left) + AS03_CountTotalNode(root.right);
        }
    }
}
