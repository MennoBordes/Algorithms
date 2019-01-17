using OpenSpeelkaarten.Comparators;
using System;

namespace OpenSpeelkaarten.Searchers.Array
{
    abstract class AbsArraySearch<T> : ISearch<T, T[]>
    {
        protected IComparator<T> comparator;

        public bool BinarySearch(T[] list, T target)
        {
            throw new NotImplementedException();
        }
    }
}
