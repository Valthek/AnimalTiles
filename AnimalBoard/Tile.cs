using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalBoard
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
