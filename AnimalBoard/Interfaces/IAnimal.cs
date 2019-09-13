using AnimalBoard.Objects;

namespace AnimalBoard.Interfaces
{
    public interface IAnimal : IObject
    {
        void Move(Position vector);
        void TakeAction(Tile environment);
    }
}
