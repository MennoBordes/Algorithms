using System;

namespace OpenSpeelkaarten.Structures.Nodes.TreeNodes
{
    abstract class AbsTreeNode<T> : ITreeNode<T>
    {
        protected T value;
        protected ITreeNode<T> leftChild, rightChild, parent;

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public ITreeNode<T> GetLeftChild()
        {
            throw new NotImplementedException();
        }

        public ITreeNode<T> GetParent()
        {
            throw new NotImplementedException();
        }

        public ITreeNode<T> GetRightChild()
        {
            throw new NotImplementedException();
        }

        public T GetValue()
        {
            throw new NotImplementedException();
        }

        public bool IsLeaf()
        {
            throw new NotImplementedException();
        }

        public void SetLeftChild(ITreeNode<T> node)
        {
            throw new NotImplementedException();
        }

        public void SetPartent(ITreeNode<T> node)
        {
            throw new NotImplementedException();
        }

        public void SetRightChild(ITreeNode<T> node)
        {
            throw new NotImplementedException();
        }
    }
}
