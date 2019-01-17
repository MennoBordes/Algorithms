using System;
using OpenSpeelkaarten.Comparators;
using OpenSpeelkaarten.Structures.Cards;
using OpenSpeelkaarten.Structures.SLL;
using OpenSpeelkaarten.Structures.Stack;
using OpenSpeelkaarten.Structures.Queue;
using OpenSpeelkaarten.Structures.Tree;
using OpenSpeelkaarten.Sorters.Array;
using OpenSpeelkaarten.Sorters.List;
using OpenSpeelkaarten.Sorters.SingleLinkedList;
using OpenSpeelkaarten.Searchers.Array;
using OpenSpeelkaarten.Searchers.List;
using OpenSpeelkaarten.Searchers.SingleLinkedList;

namespace OpenSpeelkaarten.Tests
{
    class CardTests:AbsTests<Card>
    {
        public CardTests()
        {
            comparator = new CardComparator();
        }

        public override void TestSLL()
        {
            //Example:

            //Create deck and SingleLinkedList.
            Deck deck = new Deck(false);
            ISingleLinkedList<Card> SLL = new SingleLinkedList<Card>();

            ///Draw a selected amount of cards from the deck.
            for (int i = 0; i < 7; i++)
            {
                SLL.Insert(deck.Pop());
            }

            //Perform tests
            SLL.Display();
            SLL.DeleteHead();
            SLL.Display();
        }

        public override void TestQueue()
        {
            throw new NotImplementedException();
        }

        public override void TestSearch()
        {
            throw new NotImplementedException();
        }

        public override void TestSort()
        {
            throw new NotImplementedException();
        }

        public override void TestStack()
        {
            throw new NotImplementedException();
        }

        public override void TestTree()
        {
            throw new NotImplementedException();
        }
    }
}
