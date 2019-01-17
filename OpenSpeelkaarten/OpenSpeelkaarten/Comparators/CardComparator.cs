using System;
using OpenSpeelkaarten.Structures.Cards;

namespace OpenSpeelkaarten.Comparators
{
    class CardComparator:IComparator<Card>
    {
        string[] values = { "A","K", "V", "B", "10", "9", "8","7","6","5","4","3","2" };
        string[] types = { "Schoppen","Harten","Klaveren", "Ruiten"};

        public int Compare(Card compareElement, Card target)
        {
            string searchValue = compareElement.GetCardValue();
            string searchType = compareElement.GetCardType();

            string sourceValue = target.GetCardValue();
            string sourceType = target.GetCardType();

            bool searchValueHit = false;
            bool sourceValueHit = false;

            bool searchTypeHit = false;
            bool sourceTypeHit = false;

            if (searchValue != sourceValue)
            {
                foreach (string value in values)
                {
                    if (searchValue == value)
                    {
                        searchValueHit = true;
                    }
                    if (sourceValue == value)
                    {
                        sourceValueHit = true;
                    }

                    if (searchValueHit)
                    {
                        return 1;
                    }
                    if (sourceValueHit)
                    {
                        return -1;
                    }
                }
                throw new NotFiniteNumberException();
            }
            else
            {
                if (searchType == sourceType)
                {
                    return 0;
                }
                else
                {
                    foreach (string type in types)
                    {
                        if (searchType == type)
                        {
                            searchTypeHit = true;
                        }
                        if (sourceType == type)
                        {
                            sourceTypeHit = true;
                        }

                        if (searchTypeHit)
                        {
                            return 1;
                        }
                        if (sourceTypeHit)
                        {
                            return -1;
                        }
                    }
                    throw new NotFiniteNumberException();
                }
            }
        }
    }
}