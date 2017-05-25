using ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
