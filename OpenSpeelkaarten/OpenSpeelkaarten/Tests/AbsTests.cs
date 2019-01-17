using OpenSpeelkaarten.Comparators;

namespace OpenSpeelkaarten.Tests
{
    abstract class AbsTests<T> : ITests<T>
    {
        protected IComparator<T> comparator;

        abstract public void TestQueue();

        abstract public void TestSearch();

        abstract public void TestSLL();

        abstract public void TestSort();

        abstract public void TestStack();

        abstract public void TestTree();
    }
}
