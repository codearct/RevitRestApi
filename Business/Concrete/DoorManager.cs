using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Business.ViewModel.DoorVM;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DoorManager : IDoorService
    {
        private readonly IMapper _mapper;
        private readonly IDoorDal _doorDal;
        public DoorManager(IMapper mapper, IDoorDal doorDal)
        {
            _mapper = mapper;
            _doorDal = doorDal;
        }
        public IDataResult<List<DoorViewModel>> GetAll()
        {
            var doors = _doorDal.GetAll();

            List<DoorViewModel> doorVMs = _mapper.Map<List<DoorViewModel>>(doors);

            return new SuccessDataResult<List<DoorViewModel>>(doorVMs);
        }

        public IDataResult<DoorViewModel> GetById(int id)
        {
            var door = _doorDal.GetById(id);
            if (door is null)
            {
                return new ErrorDataResult<DoorViewModel>(Messages.AreaNotExist);
            }

            DoorViewModel doorVM = _mapper.Map<DoorViewModel>(door);

            return new SuccessDataResult<DoorViewModel>(doorVM);
        }
    }
}
