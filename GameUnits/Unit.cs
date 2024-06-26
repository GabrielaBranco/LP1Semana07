using System;

namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;
        public abstract float Cost { get; }
        public virtual int Health { get; set; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move()
        {
            Console.WriteLine($"Moved: { movement }");
        }

        public override string ToString()
        {
            return $"{GetType().Name}: HP={Health} COST={Cost.ToString("0.00")}";
        }
    }
}
