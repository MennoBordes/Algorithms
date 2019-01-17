using OpenSpeelkaarten.Structures.Nodes.TreeNodes;

namespace OpenSpeelkaarten.Structures.Tree
{
    interface ITree<T>
    {
        /// <summary>
        /// (Recursive)
        /// Adds a new value to the tree.
        /// </summary>
        /// <param name="value">Value which will be added to the tree</param>
        /// <param name="node">Node to which the the value will be added. (Start at the root!)</param>
        void Add(T value, ITreeNode<T> node);
        
        /// <summary>
        /// Removes a value from the tree.
        /// </summary>
        /// <param name="value"></param>
        void Remove(T value);
        
        /// <summary>
        /// Prints the tree in a traverse pre order manner.
        /// </summary>
        /// <param name="node">Starting node. (Ussualy the root!)</param>
        void TraversePreOrder(ITreeNode<T> node);

        /// <summary>
        /// Prints the tree in a traverse post order manner.
        /// </summary>
        /// <param name="node">Starting node. (Ussualy the root!)</param>
        void TraversePostOrder(ITreeNode<T> node);
        
        /// <summary>
        /// Prints the tree in a traverse in order manner.
        /// </summary>
        /// <param name="node">Starting node. (Ussualy the root!)</param>
        void TraverseInOrder(ITreeNode<T> node);
    }
}
