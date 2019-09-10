using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalBoard
{
    public interface IAnimal : IObject
    {
        void Move(Position vector);
        void TakeAction(Tile environment);
    }
}
