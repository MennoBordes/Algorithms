namespace OpenSpeelkaarten.Structures.Queue
{
    interface IQueue<T, L>
    {
        /// <summary>
        /// Adds an item to the back of the queue.
        /// </summary>
        /// <param name="value">Value to add to the queue.</param>
        void Enqueue(T value);

        /// <summary>
        /// Removes, and returns, the item in the front of the queue.
        /// </summary>
        T Dequeue();

        /// <summary>
        /// Prints the queue.
        /// </summary>
        void Display();
    }
}
