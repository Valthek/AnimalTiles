using System;
using System.Collections.Generic;
using System.Text;
using AnimalBoard;
using AnimalBoard.Objects;
using NUnit.Framework;

namespace AnimalBoardTest
{
    public class PositionTest
    {
        private Position _basePosition;
        private Position _offsetPosition;

        [SetUp]
        public void Setup()
        {
            _basePosition = new Position();
            _offsetPosition = new Position(1,-1);
        }

        [Test]
        public void EqualityTest()
        {
            Assert.AreEqual(new Position(), _basePosition);
            Assert.AreEqual(new Position(1,-1), _offsetPosition );
            Assert.AreNotEqual(_basePosition, _offsetPosition);
            Assert.Pass();
        }

        [Test]
        public void BasePositionTest()
        {
            Assert.AreEqual(0, _basePosition.x);
            Assert.AreEqual(0, _basePosition.y);
            Assert.Pass();
        }
        [Test]
        public void OffsetPositionTest()
        {
            Assert.AreEqual(1, _offsetPosition.x);
            Assert.AreEqual(-1, _offsetPosition.y);
            Assert.Pass();
        }
        [Test]
        public void MovePositionTest()
        {
            _basePosition += new Position(1,0);
            Assert.AreEqual(1, _basePosition.x);
            Assert.AreEqual(0, _basePosition.y);
            Assert.Pass();
        }

    }
}
