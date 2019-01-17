using OpenSpeelkaarten.Comparators;

namespace OpenSpeelkaarten.Sorters.Array
{
    class ArraySort<T>: AbsArraySort<T>
    {
        public ArraySort(IComparator<T> comparator)
        {
            this.comparator = comparator;
        }
    }
}
