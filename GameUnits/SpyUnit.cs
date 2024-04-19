namespace GameUnits
{
    public class SpyUnit : XPUnit
    {
        private float _cost;
        
        public override float Cost
        {
            get => _cost;
        }

        public SpyUnit() : base (movement : 8, health : 2)
        {
            _cost = 12.5f;
        }

        public void GetSecretInfo(Unit unit)
        {
            if (unit is SpyUnit) {XP += 3;}
            else if (unit is MilitaryUnit) {XP += 2;}
            else {XP += 1;}
        }
    }
}