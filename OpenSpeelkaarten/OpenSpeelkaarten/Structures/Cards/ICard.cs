namespace OpenSpeelkaarten.Structures.Cards
{
    interface ICard
    {
        /// <summary>
        /// Retruns the type of a card.
        /// </summary>
        /// <returns>String</returns>
        string GetCardType();
        
        /// <summary>
        /// Returns the value of a card.
        /// </summary>
        /// <returns>String</returns>
        string GetCardValue();

        /// <summary>
        /// Returns the following card representation: "[Type] [Value]"
        /// </summary>
        /// <returns>String</returns>
         void Print();
    }
}
