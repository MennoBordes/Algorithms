namespace OpenSpeelkaarten.Structures.Queue
{
    abstract class AbsQueue<T, L> : IQueue<T, L>
    {
        protected L elements;

        abstract public T Dequeue();

        abstract public void Display();

        abstract public void Enqueue(T value);
    }
}
