namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public override float Cost
        {
            get
            {
                return 5;
            }
        }
        public SettlerUnit() : base ( movement: 1, health: 3 ){}
    }
}