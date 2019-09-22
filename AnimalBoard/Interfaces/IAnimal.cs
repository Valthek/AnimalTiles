using AnimalBoard.Objects;

namespace AnimalBoard.Interfaces
{
    public interface IAnimal : IObject
    {
        void Move(Position vector);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="environment"> The Environment</param>
        void TakeAction(Tile environment);

    }
}
