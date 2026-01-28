namespace DesignPattern.AbstractFactory.Interfaces
{
    public interface IAbstractFactory
    {
        IButton CreateButton();
        IList CreateList();
    }
}
