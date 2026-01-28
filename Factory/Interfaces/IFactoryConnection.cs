namespace DesignPattern.Factory.Interfaces
{
    public interface IFactoryConnection<T>
    {
        T CreateItem();
    }
}
