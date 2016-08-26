namespace Santase.Test
{
    using System;
    using NUnit.Framework;
    using Santase.Logic.Cards;
    using Santase.Logic;
    using System.Collections.Generic;

    [TestFixture]
    public class DeckTest
    {
        private const int CardsInFullDeckCount = 24;
        private readonly int zero = 0;
        private readonly int one = 1;

        [Test]
        public void NUnit_Test()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void TrumpCards_ShouldNotBeNullable()
        {
            Deck deck = new Deck();
            Assert.IsNotNull(deck.TrumpCard);
        }

        [Test]
        public void CardsLeft_AfterCreatingnewDeckCardsInDeckShouldBe24()
        {
            Deck deck = new Deck();
            int cardsInDeck = deck.CardsLeft;

            Assert.AreEqual(cardsInDeck, CardsInFullDeckCount);
        }

        [Test]
        public void GetNextCard_AfterGettingNextCardReturnedObjectShouldBeCard()
        {
            Deck deck = new Deck();
            Card validCard = new Card(CardSuit.Club, CardType.Ace);
            var aCardFromDeck = deck.GetNextCard();

            Assert.AreEqual(aCardFromDeck.GetType(), validCard.GetType());
        }

        [Test]
        public void GetNextCard_AfterGettingNextCardRemainingcardsShouldBe23()
        {
            Deck deck = new Deck();
            //Card validCard = new Card(CardSuit.Club, CardType.Ace);
            var cardFromDeck = deck.GetNextCard();

            Assert.AreEqual(deck.CardsLeft, (CardsInFullDeckCount - 1));
        }

        [Test]
        public void GetNextCard_AfterGetting24CardsCardsLeftInDeckShouldBeZero()
        {
            Deck deck = new Deck();
            int zero = 0;

            for (int i = 0; i < CardsInFullDeckCount; i++)
            {
                var cardFromDeck = deck.GetNextCard();
            }            

            Assert.AreEqual(zero, deck.CardsLeft);
        }

        [Test]
        public void GetNextCard_AfterGetting25CardsDeckIsEmptyAndShouldThrowNeExeption()
        {
            Deck deck = new Deck();
            int zero = 0;

            Card cardFromDeck;

            for (int i = 0; i < CardsInFullDeckCount; i++)
            {
                cardFromDeck = deck.GetNextCard();
            }

            //Assert.Throws<InternalGameException>(() => cardFromDeck = deck.GetNextCard());
            Assert.That(() => cardFromDeck = deck.GetNextCard(), Throws.Exception.TypeOf<InternalGameException>());
        }

        [Test]
        public void GetNextCard_CheckForDuplicateCardsInDeck()
        {
            Deck deck = new Deck();
            HashSet<Card> cards = new HashSet<Card>();
            
            for (int i = 0; i < CardsInFullDeckCount; i++)
            {
                Card card = deck.GetNextCard();
                cards.Add(card);
            }

            string msg = "Duplicate card in deck ";
            foreach (Card card in cards)
            {
                Assert.IsTrue(cards.Contains(card), msg + card.ToString());
            }
        }

        //[Test]
        [TestCase(1)]
        // Folowing two lines are for testing the parametrized test in NUnit
        // Uncomment if wont to see the result!
        //[TestCase(2)]
        //[TestCase(0)]
        public void ChangeTrumpCard_ShouldPutTheCardAtTheEndOfTheTrump(int param)
        {
            Deck deck = new Deck();
            Card cardAceClub = new Card(CardSuit.Club, CardType.Ace);

            deck.ChangeTrumpCard(cardAceClub);

            for (int i = 0; i < CardsInFullDeckCount - 1; i++)
            {
                Card nextCard = deck.GetNextCard();
            }

            // int oneCardleft = 1;
            int oneCardleft = param;
            Assert.AreEqual(oneCardleft, deck.CardsLeft);

            Card lastCard = deck.GetNextCard();
            Assert.AreEqual(cardAceClub, lastCard);
        }

    }
}
