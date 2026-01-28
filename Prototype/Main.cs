using DesignPattern.Prototype.Imp;
using DesignPattern.Prototype.Interfaces;

namespace DesignPattern.Prototype
{
    /// <summary>
    /// TODO: Prototype
    /// </summary>
    public class Main
    {
        public void ExecuteExamplePrototype()
        {
            // Create a concrete prototype (a red circle).
            IShape circlePrototype = new Circle("red");

            // Create a client and give it the prototype.
            ShapeClient client = new(circlePrototype);

            // Use the prototype to create a new shape (a red circle).
            IShape redCircle = client.createShape();

            // Draw the newly created red circle.
            redCircle.Draw();
        }
    }
}
