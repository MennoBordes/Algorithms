using System;

namespace OpenSpeelkaarten.Structures.Nodes.SingleLinkedListNodes
{
    abstract class AbsSingleLinkedListNode<T> : ISingleLinkedListNode<T>
    {
        protected bool isEmpty;
        protected T value;
        protected ISingleLinkedListNode<T> tail;

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public ISingleLinkedListNode<T> GetNext()
        {
            throw new NotImplementedException();
        }

        public T GetValue()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public void SetTail(ISingleLinkedListNode<T> tail)
        {
            throw new NotImplementedException();
        }
    }
}
