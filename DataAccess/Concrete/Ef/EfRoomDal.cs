using Core.DataAccess.Ef;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Ef
{
    public class EfRoomDal : EfEntityRepositoryBase<Room, RevitSampleProjectDBContext>, IRoomDal
    {
        public ICollection<Room> GetAll()
        {
            using (RevitSampleProjectDBContext context = new RevitSampleProjectDBContext())
            {
                var rooms = context.Rooms
                    .Include(r => r.DesignOptionNavigation)
                    .Include(r => r.Phase)
                    .Include(r => r.LevelNavigation)
                    .Include(r => r.RoomAssociations)
                        .ThenInclude(ra => ra.Phase)
                    .Include(r => r.RoomFromToAssociationFromRoomNavigations)
                        .ThenInclude(ra => ra.ToRoomNavigation)
                    .Include(r => r.RoomFromToAssociationToRoomNavigations)
                        .ThenInclude(ra => ra.FromRoomNavigation)
                    .OrderBy(r => r.Id)
                    .ToList();

                return rooms;
            }           
        }

        public Room GetByNumber(int roomNumber)
        {
            using (RevitSampleProjectDBContext context = new RevitSampleProjectDBContext())
            {
                var room = context.Rooms
                    .Include(r => r.DesignOptionNavigation)
                    .Include(r => r.Phase)
                    .Include(r => r.LevelNavigation)
                    .Include(r => r.RoomAssociations)
                        .ThenInclude(ra => ra.Phase)
                    .Include(r => r.RoomFromToAssociationFromRoomNavigations)
                        .ThenInclude(ra => ra.ToRoomNavigation)
                    .Include(r => r.RoomFromToAssociationToRoomNavigations)
                        .ThenInclude(ra => ra.FromRoomNavigation)
                    .SingleOrDefault(r => Convert.ToInt32(r.Number) == roomNumber);
                
                return room;
            }
        }
    }
}
