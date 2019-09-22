using System.Collections.Generic;
using AnimalBoard.Interfaces;
using AnimalBoard.Library.Objects;
using AnimalBoard.Objects;

namespace AnimalBoard.Services
{
    public class GameService
    {
        public List<Tile> Board { get; set; }
        public List<IAnimal> Animals { get; set; }
        

        public GameService(int boardWidth, int boardHeight)
        {
            InitializeBoard(boardWidth, boardHeight);
            Animals = new List<IAnimal>()
            {
                new Rabbit()
                {
                    Position = new Position(2,2)
                }
            };
        }

        private void InitializeBoard(int width, int height)
        {
            Board = new List<Tile>();
            for(int x = 0; x< width; x++)
                for(int y = 0; y < height; y++)
                    Board.Add(new Tile
                        { Position = new Position(x,y)}
                    );
        }
    }
}
