namespace OpenSpeelkaarten.Sorters
{
    interface ISort<T, L>
    {
        /// <summary>
        /// Performs a insertion sort on a given list.
        /// </summary>
        /// <param name="list">The list you would like to sort.</param>
        /// <returns>New list with the same type as the input list.</returns>
        L InsertionSort(L list);
    }
}
