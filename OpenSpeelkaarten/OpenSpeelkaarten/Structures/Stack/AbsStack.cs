namespace OpenSpeelkaarten.Structures.Stack
{
    abstract class AbsStack<T, L> : IStack<T, L>
    {
        protected L elements;
        abstract public bool IsEmpty();
        abstract public T Peek();
        abstract public T Pop();
        abstract public void Push(T value);
    }
}
