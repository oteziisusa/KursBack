using System.Web.Http;
using ModelDB.ModelDB;
using WebApi.IDatabase;

namespace WebApi.Controllers
{
    public class ItemController : ApiController
    {
        IItemRepository itemRepository;
        void AddItem(Item item)
        {
            itemRepository.AddItem(item);
        }
        void UpdateItem(int idItem, Item item)
        {
            itemRepository.UpdateItem(idItem, item);
        }
        void ChangeItemPosition(int idItem, int idNewParentCategory)
        {
            itemRepository.ChangeItemPosition(idItem, idNewParentCategory);
        }
        void DeleteItem(int idItem)
        {
            itemRepository.DeleteItem(idItem);
        }
    }
}
