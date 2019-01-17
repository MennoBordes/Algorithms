using OpenSpeelkaarten.Comparators;
using OpenSpeelkaarten.Structures.Nodes.TreeNodes;
using System;

namespace OpenSpeelkaarten.Structures.Tree
{
    abstract class AbsTree<T> : ITree<T>
    {
        protected ITreeNode<T> root;
        protected IComparator<T> comparator;

        public void Add(T value, ITreeNode<T> node)
        {
            throw new NotImplementedException();
        }

        public void Remove(T value)
        {
            throw new NotImplementedException();
        }

        public void TraverseInOrder(ITreeNode<T> node)
        {
            throw new NotImplementedException();
        }

        public void TraversePostOrder(ITreeNode<T> node)
        {
            throw new NotImplementedException();
        }

        public void TraversePreOrder(ITreeNode<T> node)
        {
            throw new NotImplementedException();
        }
    }
}
