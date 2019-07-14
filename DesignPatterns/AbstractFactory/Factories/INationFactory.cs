using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public interface INationFactory
    {
        ILongableRangeUnit CreateLongableRangeUnit();
        IShortableRangeUnit CreateShortableRangeUnit();
    }
}
