using OpenSpeelkaarten.Structures.Cards;
using OpenSpeelkaarten.Tests;

//  De OpenSpeelkaarten applicatie is op te delen in twee onderdelen, één deel datastructuren ("Structures" map) en één deel algoritmiek
//  ("Searchers" en "Sorters" map). Beide onderdelen bevatten een basis structuur voor een applicatie waarin gewerkt wordt met kaarten 
//  echter mist hierin de implementatie van gedrag. Het is dan ook de opdracht om deze missende functionaliteit toe te voegen 
//  waardoor de verschillende, zelf te schrijven, tests goed worden uitgevoerd.

//  De opbouw van classes is als volgt:
//  1. Interface      (Definitie van gedrag voor een class)
//  2. Abstract Class (Definitie van attributen, implementatie van gedrag (mits mogelijk))
//  3. Class          (Instatieren van variabelen en implementatie van gedrag (mits nodig))

//  Om de applicatie in "chronologische volgorde" af te maken volg je de volgende stappen:
//  1. Structures -> Nodes -> SingleLinkedListNodes
//  2. Structures -> SLL
//  3. Structures -> Stack
//  4. Structures -> Queue
//  5. Sorters
//  6. Searchers
//  7. Structures -> Nodes -> TreeNodes
//  8. Structures -> Tree

namespace OpenSpeelkaarten
{
    class Program
    {
        /// <summary>
        /// Perform tests to see if your implementation of datastructures and algorithms work.
        /// </summary>
        static void Main(string[] args)
        {
            ITests<Card> CardTest = new CardTests();
            CardTest.TestSLL();
        }
    }
}
