namespace API.Interfaces
{
    public interface IDatabase
    {
        List<string> GetItem();
        void AddItem(string item);
        void RemoveItem(string item);
    }
}
