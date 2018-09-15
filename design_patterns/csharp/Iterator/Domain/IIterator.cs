namespace Iterator.Domain
{
    public interface IIterator
    {
        bool HasNext();
        string Next();
    }
}