namespace OpenSpeelkaarten.Tests
{
    interface ITests<T>
    {
        /// <summary>-
        /// Performs a test for the single linked list data structure.
        /// </summary>
        void TestSLL();
        
        /// <summary>
        /// Performs tests for the search algorithms.
        /// </summary>
        void TestSearch();

        /// <summary>
        /// Performs tests for the sort algorithms.
        /// </summary>
        void TestSort();

        /// <summary>
        /// Performs tests for the tree data structure.
        /// </summary>
        void TestTree();
                    
        /// <summary>
        /// Performs tests for the stack data structure.
        /// </summary>
        void TestStack();

        /// <summary>
        /// Performs tests for the queue data structure.
        /// </summary>
        void TestQueue();
    }
}
