using OpenSpeelkaarten.Comparators;
using OpenSpeelkaarten.Structures.SLL;
using System;

namespace OpenSpeelkaarten.Searchers.SingleLinkedList
{
    class AbsSingleLinkedListSearch<T> : ISearch<T, ISingleLinkedList<T>>
    {
        protected IComparator<T> comparator;
        public bool BinarySearch(ISingleLinkedList<T> list, T target)
        {
            throw new NotImplementedException();
        }
    }
}
