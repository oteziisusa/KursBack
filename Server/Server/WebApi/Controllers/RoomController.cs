using System.Collections.Generic;
using System.Web.Http;
using ModelDB.ModelDB;
using WebApi.IDatabase;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class RoomController : ApiController
    {
        IRoomRepository roomRepository;

        public IEnumerable<Room> GetRooms()
        {
            var rooms = roomRepository.GetRooms();
            return rooms;
        }

        public IEnumerable<Room> GetRooms(IEnumerable<Category> filter)
        {
            var rooms = roomRepository.GetRooms(filter);
            return rooms;
        }

        public RoomInfo GetRoomInfo(int numberRoom, IEnumerable<Category> filter)
        {
            var roomInfo = roomRepository.GetRoomInfo(numberRoom, filter);
            return roomInfo;
        }

        public CategoryInfo GetCategoryInfo(int idCategory, int idRoom)
        {
            var categoryInfo = roomRepository.GetCategoryInfo(idCategory, idRoom);
            return categoryInfo;
        }
    }
}
