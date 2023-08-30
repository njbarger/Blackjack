using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Library.Tests
{
    [TestClass()]
    public class BlackjackHandTests
    {

        [TestMethod()]
        public void AddCardTest()
        {
            BlackjackHand testHand = new BlackjackHand();
            testHand.AddCard(CardFactory.CreateBlackjackCard(CardFace.Ace, CardSuit.Clubs));
            testHand.AddCard(CardFactory.CreateBlackjackCard(CardFace.Eight, CardSuit.Clubs));

            Assert.AreEqual(testHand.Score, 19);

            testHand.AddCard(CardFactory.CreateBlackjackCard(CardFace.Ten, CardSuit.Clubs));

            Assert.AreEqual(testHand.Score, 19);
        }
    }
}