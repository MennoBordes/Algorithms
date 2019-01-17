namespace OpenSpeelkaarten.Comparators
{
    interface IComparator<T>
    {
        /// <summary>
        /// Compare a element against a target to see if the element is smaller, equal or bigger.
        /// </summary>
        /// <param name="compareElement"> The element that you would like to compare.</param>
        /// <param name="target">The element that you're comparing against</param>
        /// <returns> -1 (smaller), 0 (equal) or 1 (bigger) /// </returns>
        int Compare(T compareElement, T target);
    }
}
