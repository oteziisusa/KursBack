using System.Collections.Generic;
using ModelDB.ModelDB;
using WebApi.Models;

namespace WebApi.IDatabase
{
    public interface IRoomRepository
    {
        IEnumerable<Room> GetRooms(IEnumerable<Category> filter = null);

        RoomInfo GetRoomInfo(int numberRoom, IEnumerable<Category> filter);

        CategoryInfo GetCategoryInfo(int idCategory, int idRoom);
    }
}
