using System;
using ModelDB.ModelDB;
using WebApi.IDatabase;

namespace WebApi.Database
{
    public class ItemRepository : IItemRepository
    {
        private readonly ModeDB _model;

        public ItemRepository()
        {
            _model = new ModeDB();
        }

        public void AddItem(Item item)
        {
            _model.Item.Add(item);
            _model.SaveChanges();
        }

        public void ChangeItemPosition(int idItem, int idNewParentCategory)
        {
            var item = _model.Item.Find(idItem);
            if (item != null)
                item.CategoryId = idNewParentCategory;
            _model.SaveChanges();
        }

        public void DeleteItem(int idItem)
        {
            var item = _model.Item.Find(idItem);
            if (item != null)
                _model.Item.Remove(item);
            _model.SaveChanges();
        }

        public void UpdateItem(int idItem, Item item)
        {
            var itemDb = _model.Item.Find(idItem);
            if (itemDb != null)
            {
                itemDb.Name = item.Name;
                itemDb.CategoryId = item.CategoryId;
                itemDb.NumberRoom = item.NumberRoom;
                itemDb.RegistrationNumber = item.RegistrationNumber;

                _model.SaveChanges();
            }
        }
    }
}