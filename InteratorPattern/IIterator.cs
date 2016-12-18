namespace InteratorPattern
{
    internal interface IIterator
    {
        bool IsDone { get; }
        Item CurrentItem { get; }
        Item First();
        Item Next();
    }
}