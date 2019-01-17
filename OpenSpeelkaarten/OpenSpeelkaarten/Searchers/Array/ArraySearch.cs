using OpenSpeelkaarten.Comparators;
using OpenSpeelkaarten.Searchers.Array;

namespace OpenSpeelkaarten.Searchers
{
    class ArraySearch<T> : AbsArraySearch<T>
    {
        public ArraySearch(IComparator<T> comparator)
        {
            this.comparator = comparator;
        }
    }
}