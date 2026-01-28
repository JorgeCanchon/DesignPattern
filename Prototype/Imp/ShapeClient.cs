using DesignPattern.Prototype.Interfaces;

namespace DesignPattern.Prototype.Imp
{
    public class ShapeClient
    {
        private IShape _shapePrototype;

        public ShapeClient(IShape shapePrototype)
        {
            _shapePrototype = shapePrototype;
        }

        public IShape createShape()
        {
            return _shapePrototype.Clone();
        }
    }
}
