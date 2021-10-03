using AutoMapper;
using Business.Abstract;
using Business.ViewModel.RoomVM;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IMapper _mapper;
        private readonly IRoomDal _roomDal;
        public RoomManager(IMapper mapper, IRoomDal roomDal)
        {
            _mapper = mapper;
            _roomDal = roomDal;
        }
        public List<RoomViewModel> GetAll()
        {
            var rooms = _roomDal.GetAll();
            List<RoomViewModel> roomVMs = _mapper.Map<List<RoomViewModel>>(rooms);
            return roomVMs;
        }

        public RoomViewModel GetByNumber(int roomNumber)
        {
            var room = _roomDal.GetByNumber(roomNumber);
            RoomViewModel roomVM = _mapper.Map<RoomViewModel>(room);
            return roomVM;
        }
    }
}
