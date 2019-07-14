using AbstractFactory.Interfaces;

namespace AbstractFactory.Entities
{
    public class JapaneseArcher : ILongableRangeUnit
    {
        public string Name => "Japanese Archer";

        public void Shoot()
        {

        }
    }
}
