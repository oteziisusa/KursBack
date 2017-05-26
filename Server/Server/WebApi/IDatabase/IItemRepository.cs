using ModelDB.ModelDB;

namespace WebApi.IDatabase
{
    public interface IItemRepository
    {
        void AddItem(Item item);
        void UpdateItem(int idItem, Item item);
        void ChangeItemPosition(int idItem, int idNewParentCategory);
        void DeleteItem(int idItem);
    }
}
