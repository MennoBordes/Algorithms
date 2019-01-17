namespace OpenSpeelkaarten.Structures.Nodes.SingleLinkedListNodes
{
    interface ISingleLinkedListNode<T>
    {
        /// <summary>
        /// Returns if the node is empty.
        /// </summary>
        bool IsEmpty();
        
        /// <summary>
        /// Returns the tail of the current node.
        /// </summary>
        ISingleLinkedListNode<T> GetNext();
        
        /// <summary>
        /// Returns the value within the node.
        /// </summary>
        T GetValue();
        
        /// <summary>
        /// Set, or replace, the tail of the node.
        /// </summary>
        /// <param name="tail">New tail for the node.</param>
        void SetTail(ISingleLinkedListNode<T> tail);
        
        /// <summary>
        /// Removes the tail of the node.
        /// </summary>
        void Disconnect();
    }
}
