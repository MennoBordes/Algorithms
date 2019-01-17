using System;

namespace OpenSpeelkaarten.Structures.Cards

{
    class AbsCard :ICard
    {
        protected string value, type;

        public string GetCardType()
        {
            return type;
        }

        public string GetCardValue()
        {
            return value;
        }

        public void Print()
        {
           Console.WriteLine(string.Format("{0} {1}", type, value));
        }
    }
}
