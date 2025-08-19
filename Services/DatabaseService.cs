using API.Interfaces;

namespace API.Services
{
    public class DatabaseService : IDatabase
    {
        private List<string> _item = new List<string>();

        public List<string> GetItem()
        {
            return _item;
        }

        public void AddItem(string item)
        {
            _item.Add(item);
        }


        public void RemoveItem(string item)
        {
            _item.Remove(item);
        }
    }
}
