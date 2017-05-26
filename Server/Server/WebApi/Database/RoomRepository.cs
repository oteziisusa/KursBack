using System;
using System.Collections.Generic;
using System.Linq;
using ModelDB.ModelDB;
using WebApi.IDatabase;
using WebApi.Models;

namespace WebApi.Database
{
    public class RoomRepository : IRoomRepository
    {
        private readonly ModeDB _model;

        public RoomRepository()
        {
            _model=new ModeDB();
        }
        public CategoryInfo GetCategoryInfo(int idCategory, int idRoom)
        {
            throw new NotImplementedException();
        }

        public RoomInfo GetRoomInfo(int numberRoom, IEnumerable<Category> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Room> GetRooms(IEnumerable<Category> filter = null)
        {
            if (filter==null)
            {
                return _model.Room.ToList();
            }
            return _model.Room.ToList();
            //else
            //{
            //    var categories=new List<Category>();

            //    //foreach (var VARIABLE in _model.)
            //    //{

            //    //}
            //}
        }
    }
}