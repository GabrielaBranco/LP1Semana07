namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public override float Cost
        {
            get => 5;
        }
        public SettlerUnit() : base ( movement: 1, health: 3 ){}
    }
}