using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit military = new MilitaryUnit(2,50,25);
            Unit settler = new SettlerUnit();

            military.Move();
            settler.Move();

            Console.WriteLine
            ($"Military Health = {military.Health}\nMilitary Cost = {military.Cost}");
            Console.WriteLine
            ($"Settler Health = {settler.Health}\nSettler Cost = {settler.Cost}");
        }
    }
}
