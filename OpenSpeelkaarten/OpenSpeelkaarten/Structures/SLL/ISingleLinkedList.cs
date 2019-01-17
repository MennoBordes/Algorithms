using OpenSpeelkaarten.Structures.Nodes.SingleLinkedListNodes;

namespace OpenSpeelkaarten.Structures.SLL
{
    interface ISingleLinkedList<T>
    {
        /// <summary>
        /// Adds a value to the head of the SLL.
        /// </summary>
        /// <param name="value">Value which will be added to the SLL.</param>
        void Insert(T value);
        
        /// <summary>
        /// Add a value at the end of the SLL
        /// </summary>
        /// <param name="value">Value which will be added to the SLL.</param>
        void InsertAtEnd(T value);
        
        /// <summary>
        /// Adds a value after a specific value already contained in the SLL.
        /// </summary>
        /// <param name="value">Value which will be added to the SLL.</param>
        /// <param name="targetValue">The value afterwhich "value" will be added.</param>
        void InsertAfter(T value, T targetValue);
        
        /// <summary>
        /// Removes the head of the SLL.
        /// </summary>
        void DeleteHead();
        
        /// <summary>
        /// Removes the last item in the SLL.
        /// </summary>
        void DeleteEnd();
        
        /// <summary>
        /// Removes a specific value from the SLL.
        /// </summary>
        /// <param name="value">Value which will be removed from the SLL.</param>
        void DeleteSpecific(T value);
        
        /// <summary>
        /// Prints all elements of the SLL.
        /// </summary>
        void Display();

        T GetHeadValue();

        T GetEndValue();
    }
}
