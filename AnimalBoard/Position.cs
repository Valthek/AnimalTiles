using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AnimalBoard
{
    public class Position
    {
        public int x { get; set; }
        public int y { get; set; }

        public Position()
        {
            x = 0;
            y = 0;
        }

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        public override bool Equals(object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Position p = (Position)obj;
                return (x == p.x) && (y == p.y);
            }
        }

        protected bool Equals(Position other)
        {
            return x == other.x && y == other.y;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (x * 397) ^ y;
            }
        }

        public static Position operator +(Position a, Position b)
        {
            Position p = new Position();
            p.x = a.x + b.x;
            p.y = a.y + b.y;
            return p;
        }
    }
}
