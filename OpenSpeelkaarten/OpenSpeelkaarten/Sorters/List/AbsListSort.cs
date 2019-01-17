using OpenSpeelkaarten.Comparators;
using System;
using System.Collections.Generic;

namespace OpenSpeelkaarten.Sorters.List
{
    class AbsListSort<T> : ISort<T, List<T>>
    {
        protected IComparator<T> comparator;
        public List<T> InsertionSort(List<T> list)
        {
            throw new NotImplementedException();
        }
    }
}
