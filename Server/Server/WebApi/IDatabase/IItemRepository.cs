using ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.IDatabase
{
    public interface IItemRepository
    {
        void AddItem(Item item);
        void UpdateItem(int idItem, string nameItem);
        void ChangeItemPosition(int idItem, int idNewParentCategory);
        void DeleteItem(int idItem);
    }
}
