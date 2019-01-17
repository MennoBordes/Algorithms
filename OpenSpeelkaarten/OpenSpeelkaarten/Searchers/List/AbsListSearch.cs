using OpenSpeelkaarten.Comparators;
using System;
using System.Collections.Generic;

namespace OpenSpeelkaarten.Searchers.List
{
    class AbsListSearch<T> : ISearch<T, List<T>>
    {
        protected IComparator<T> comparator;    
        public bool BinarySearch(List<T> list, T target)
        {
            throw new NotImplementedException();
        }
    }
}
