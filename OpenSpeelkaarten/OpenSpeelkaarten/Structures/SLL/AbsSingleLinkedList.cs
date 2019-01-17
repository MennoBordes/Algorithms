using System;
using OpenSpeelkaarten.Structures.Nodes.SingleLinkedListNodes;

namespace OpenSpeelkaarten.Structures.SLL
{
    class AbsSingleLinkedList<T> : ISingleLinkedList<T>
    {
        protected ISingleLinkedListNode<T> head;

        public void DeleteEnd()
        {
            throw new NotImplementedException();
        }
        
        public void DeleteHead()
        {
            throw new NotImplementedException();
        }

        public void DeleteSpecific(T value)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void InsertAfter(T value, T targetValue)
        {
            throw new NotImplementedException();
        }

        public void Insert(T value)
        {
            throw new NotImplementedException();
        }

        public void InsertAtEnd(T value)
        {
            throw new NotImplementedException();
        }

        public T GetHeadValue()
        {
            throw new NotImplementedException();
        }

        public T GetEndValue()
        {
            throw new NotImplementedException();
        }
    }
}
