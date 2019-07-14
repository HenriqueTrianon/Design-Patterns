using AbstractFactory.Interfaces;

namespace AbstractFactory.Entities
{
    public class Knight:IShortableRangeUnit
    {
        public string Name => "Knight";

        public void Hit()
        {
            
        }
    }
}
