using AnimalBoard.Interfaces;

namespace AnimalBoard.Objects
{
    public enum TileType
    {
        nothing,
        grass
    }

    public class Tile : IObject
    {
        public Position Position { get; set; }

        public TileType Type { get; set; }

    }
}
