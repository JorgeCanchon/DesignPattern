namespace DesignPattern.Prototype.Interfaces
{
    public interface IShape
    {
        void Draw();
        IShape Clone();
    }
}
