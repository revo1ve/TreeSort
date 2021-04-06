using System.Collections.Generic;

namespace TreeSort
{
    public static class TreeSort
    {
        public static List<string> GetSortedList(List<string> list)
        {
            if (list.Count < 2) return list;

            var treeNode = new TreeNode(list[0]);

            for (int i = 1; i < list.Count; i++)
                treeNode.Insert(new TreeNode(list[i]));

            return treeNode.Transform();
        }
    }
}
