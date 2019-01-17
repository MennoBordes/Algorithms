namespace OpenSpeelkaarten.Structures.Stack
{
    interface IStack<T, L>
    {
        /// <summary>
        /// Returns the top value of the stack and removes the element.
        /// </summary>
        /// <returns></returns>
        T Pop();
        
        /// <summary>
        /// Returns the top value of the stack without removing the element from the stack.
        /// </summary>
        T Peek();
        
        /// <summary>
        /// Adds a value to the top of the stack.
        /// </summary>
        /// <param name="value">Value which will be added to the stack.</param>
        void Push(T value);
        
        /// <summary>
        /// Returns if the stack is empty.
        /// </summary>
        bool IsEmpty();
    }
}
