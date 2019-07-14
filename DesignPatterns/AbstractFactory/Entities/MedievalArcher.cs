using AbstractFactory.Interfaces;

namespace AbstractFactory.Entities
{
    public class MedievalArcher: ILongableRangeUnit
    {
        public string Name => "Medieval Archer";

        public void Shoot()
        {

        }
    }
}
