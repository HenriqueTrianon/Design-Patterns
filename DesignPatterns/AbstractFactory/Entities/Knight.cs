using AbstractFactory.Interfaces;

namespace AbstractFactory.Entities
{
    public class Knight:IShortableRangeUnit
    {
        public string Name
        {
            get => "Knight";
        }
        public void Hit()
        {
            
        }
    }
}
