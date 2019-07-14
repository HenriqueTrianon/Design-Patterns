using AbstractFactory.Entities;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public class AsianFactory : INationFactory
    {
        public  ILongableRangeUnit CreateLongableRangeUnit()
        {
            return new JapaneseArcher();
        }

        public  IShortableRangeUnit CreateShortableRangeUnit()
        {
            return new Samurai();
        }
    }
}
