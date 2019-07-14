using AbstractFactory.Interfaces;

namespace AbstractFactory.Entities
{
    public class MedievalArcher: ILongableRangeUnit
    {
        public string Name
        {
            get => "Medieval Archer";
        }
        public void Shoot()
        {

        }
    }
}
