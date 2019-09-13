using System;
using System.Collections.Generic;
using System.Text;
using AnimalBoard;
using AnimalBoard.Objects;
using AnimalBoard.Services;
using NUnit.Framework;

namespace AnimalBoardTest
{
    class GameServiceTest
    {
        private GameService _gameService;

        [SetUp]
        public void Setup()
        {
            _gameService = new GameService(10, 10);
        }

        [Test]
        public void InitializeTest()
        {
            Assert.AreEqual(100, _gameService.Board.Count);
            Assert.AreEqual(null, _gameService.Animals);
            Assert.AreEqual(new Position(0,0), _gameService.Board[0].Position);
            Assert.AreEqual(new Position(9, 9), _gameService.Board[99].Position);
            Assert.Pass();
        }

    }
}
