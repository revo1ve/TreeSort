using System.Collections.Generic;

namespace TreeSort
{
    public class TreeNode
    {
        public TreeNode(string data)
        {
            Data = data;
        }

        public string Data { get; set; }

        public TreeNode Left { get; set; }

        public TreeNode Right { get; set; }

        public void Insert(TreeNode node)
        {
            var dataIsNumeric = int.TryParse(Data, out var parsedData) & int.TryParse(node.Data, out var parsedNodeData);

            if (dataIsNumeric && parsedNodeData < parsedData || !dataIsNumeric && node.Data.CompareTo(Data) == - 1)
            {
                if (Left == null) Left = node;
                else Left.Insert(node);
            }
            else
            {
                if (Right == null) Right = node;
                else Right.Insert(node);
            }
        }

        public List<string> Transform(List<string> elements = null)
        {
            if (elements == null)
                elements = new List<string>();

            if (Left != null)
                Left.Transform(elements);

            elements.Add(Data);

            if (Right != null)
                Right.Transform(elements);

            return elements;
        }
    }
}
