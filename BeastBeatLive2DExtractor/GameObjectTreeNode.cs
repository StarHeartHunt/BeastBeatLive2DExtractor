using AssetStudio;
using System.Collections.Generic;

namespace BeastBeatLive2DExtractor
{
    internal class TreeNode
    {
        public string Text { get; set; }
        public List<TreeNode> Nodes { get; }
        public TreeNode()
        {
            Text = default;
            Nodes = new List<TreeNode>();
        }

        public TreeNode(string text) : this()
        {
            Text = text;
        }
    }

    internal class GameObjectTreeNode : TreeNode
    {
        public GameObject gameObject;

        public GameObjectTreeNode(GameObject gameObject)
        {
            this.gameObject = gameObject;
            Text = gameObject.m_Name;
        }
    }
}