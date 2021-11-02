using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Business.ViewModel.Wall;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class WallManager:IWallService
    {
        private readonly IMapper _mapper;
        private readonly IWallDal _wallDal;

        public WallManager(IMapper mapper, IWallDal wallDal)
        {
            _mapper = mapper;
            _wallDal = wallDal;
        }

        public IDataResult<List<WallViewModel>> GetAll()
        {
            var walls = _wallDal.GetAll();

            List<WallViewModel> wallVMs = _mapper.Map<List<WallViewModel>>(walls);

            return new SuccessDataResult<List<WallViewModel>>(wallVMs);
        }

        public IDataResult<WallViewModel> GetById(int id)
        {
            var wall = _wallDal.GetById(id);

            if (wall is null)
            {
                return new ErrorDataResult<WallViewModel>(Messages.WallNotExist);
            }

            WallViewModel wallVM = _mapper.Map<WallViewModel>(wall);

            return new SuccessDataResult<WallViewModel>(wallVM);
        }
    }
}
