using System;
using System.Collections.Generic;
using System.Text;
using AnimalBoard.Interfaces;
using AnimalBoard.Objects;

namespace AnimalBoard.Library.Objects
{
    class Rabbit : IAnimal
    {
        public Position Position { get; set; }

        void IAnimal.Move(Position vector)
        {
            throw new NotImplementedException();
        }

        void IAnimal.TakeAction(Tile environment)
        {
            throw new NotImplementedException();
        }
    }
}
