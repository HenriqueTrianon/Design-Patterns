using AbstractFactory.Entities;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public class EuropeanFactory:INationFactory
    {
        public  ILongableRangeUnit CreateLongableRangeUnit()
        {
            return new MedievalArcher();
        }

        public  IShortableRangeUnit CreateShortableRangeUnit()
        {
            return new Knight();
        }
    }
}
