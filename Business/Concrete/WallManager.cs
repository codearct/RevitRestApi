using AutoMapper;
using Business.Abstract;
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
        private readonly IWallDal _walldal;

        public WallManager(IMapper mapper, IWallDal walldal)
        {
            _mapper = mapper;
            _walldal = walldal;
        }

        public IDataResult<List<WallViewModel>> GetAll()
        {
            var walls = _walldal.GetAll();

            List<WallViewModel> wallVMs = _mapper.Map<List<WallViewModel>>(walls);

            return new SuccessDataResult<List<WallViewModel>>(wallVMs);
        }

        public IDataResult<List<WallViewModel>> GetByType(string wallType)
        {
            var walls = _walldal.GetByType(wallType);

            List<WallViewModel> wallVMs = _mapper.Map<List<WallViewModel>>(walls);

            return new SuccessDataResult<List<WallViewModel>>(wallVMs);
        }
    }
}
