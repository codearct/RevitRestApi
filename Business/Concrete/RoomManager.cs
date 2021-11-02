using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Business.ViewModel.RoomVM;
using Core.Utilities.Results;
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
        public IDataResult<List<RoomViewModel>> GetAll()
        {
            var rooms = _roomDal.GetAll();

            List<RoomViewModel> roomVMs = _mapper.Map<List<RoomViewModel>>(rooms);

            return new SuccessDataResult<List<RoomViewModel>>(roomVMs);
        }

        public IDataResult<RoomViewModel> GetById(int id)
        {
            var room = _roomDal.GetById(id);
            if (room is null)
            {
                return new ErrorDataResult<RoomViewModel>(Messages.RoomNotExist);
            }

            RoomViewModel roomVM = _mapper.Map<RoomViewModel>(room);

            return new SuccessDataResult<RoomViewModel>(roomVM);
        }
    }
}
