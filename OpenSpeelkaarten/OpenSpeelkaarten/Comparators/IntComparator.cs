namespace OpenSpeelkaarten.Comparators
{
    class IntComparator : IComparator<int>
    {

        public int Compare(int compareElement, int target)
        {
            if (compareElement > target) return 1;
            else if (compareElement == target) return 0;
            else return -1;
        }
    }
}
