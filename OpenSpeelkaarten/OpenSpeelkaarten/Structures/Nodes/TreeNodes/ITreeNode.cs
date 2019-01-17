namespace OpenSpeelkaarten.Structures.Nodes.TreeNodes
{
    interface ITreeNode<T>
    {
        /// <summary>
        /// Returns the value within the node.
        /// </summary>
        T GetValue();
        
        /// <summary>
        /// Returns the parent of the node.
        /// </summary>
        /// <returns></returns>
        ITreeNode<T> GetParent();
        
        /// <summary>
        /// Sets the parent of the node.
        /// </summary>
        /// <param name="node">Node which will become the new parent of the node</param>
        void SetPartent(ITreeNode<T> node);
        
        /// <summary>
        /// Returns the left child of the node.
        /// </summary>
        ITreeNode<T> GetLeftChild();
        
        /// <summary>
        /// Sets the left child of the node.
        /// </summary>
        /// <param name="node">Node which will become the left child of the node.</param>
        void SetLeftChild(ITreeNode<T> node);
        
        /// <summary>
        /// Returns the right child of the node.
        /// </summary>
        ITreeNode<T> GetRightChild();
        
        /// <summary>
        /// Sets the right child of the node.
        /// </summary>
        /// <param name="node">Node which will become the right child of the node.</param>
        void SetRightChild(ITreeNode<T> node);
        
        /// <summary>
        /// Returns if the node is a leaf node.
        /// </summary>
        bool IsLeaf();
        
        /// <summary>
        /// Disconnects a node from it's parent and children.
        /// </summary>
        void Disconnect();
    }
}
